using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using MigrationAnalysing.DataAccess;

namespace MigrationAnalysing.Benchmark;

public static class BenchmarkRunner
{
    private static int migrationCount = 100;
    private static string resultPath = Path.Combine("artifacts", "results.csv");

    public static async Task RunAsync(string mode, string connection)
    {
        Directory.CreateDirectory("artifacts");

        if (!File.Exists(resultPath))
            File.WriteAllText(resultPath, "Method,MigrationCount,Milliseconds\n");

        Console.WriteLine($"== Running benchmark: {mode} ==");

        switch (mode.ToLower())
        {
            case "onstartup":
                await RevertLastNAppliedMigrationsAsync(connection, migrationCount);
                Console.WriteLine("== Benchmark: NonCompiled Models OnStartup Migration (Cold vs Warm) ==");
                var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(connection)
                    .Options;
                await ColdVsWarm(options);
                break;

            case "precompiled":
                Console.WriteLine("== Benchmark: PreCompiled Models OnStartup Migration (Cold vs Warm) ==");
                var opts = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(connection)
                    .UseModel(AppDbContextModel.Instance)
                    .Options;
                await ColdVsWarm(opts);
                break;

            case "bundle":
                await RevertLastNAppliedMigrationsAsync(connection, migrationCount);
                var bundlePath = Path.Combine("artifacts", $"bundle_{migrationCount}.exe");
                if (!File.Exists(bundlePath))
                    throw new FileNotFoundException(bundlePath);

                long elapsed = await MeasureAsync(async () =>
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = bundlePath,
                        Arguments = $"--connection \"{connection}\"",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };
                    var proc = Process.Start(psi)!;
                    string output = await proc.StandardOutput.ReadToEndAsync();
                    string error = await proc.StandardError.ReadToEndAsync();
                    await proc.WaitForExitAsync();
                    if (!string.IsNullOrWhiteSpace(error))
                        Console.WriteLine(error);
                });

                Log("Bundle", migrationCount, elapsed, resultPath);
                PrintResult("Bundle", elapsed);

                break;

            default:
                Console.WriteLine("Invalid benchmark mode. Use onstartup | precompiled | bundle");
                break;
        }
    }

    private static async Task ColdVsWarm(DbContextOptions<AppDbContext> options)
    {
        long coldElapsed = await MeasureAsync(async () =>
        {
            await using var ctx = new AppDbContext(options);
            await ctx.Database.MigrateAsync();
        });

        long warmElapsed = await MeasureAsync(async () =>
        {
            await using var ctx = new AppDbContext(options);
            await ctx.Database.MigrateAsync();
        });

        Log("OnStartup-Cold", migrationCount, coldElapsed, resultPath);
        Log("OnStartup-Warm", migrationCount, warmElapsed, resultPath);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Cold migration (first run): {coldElapsed} ms");
        Console.WriteLine($"Warm migration (cached model): {warmElapsed} ms");
        Console.WriteLine($"Startup caching gain: {coldElapsed - warmElapsed} ms");
        Console.ResetColor();
    }

    private static void Log(string method, int migrations, long ms, string path)
    {
        File.AppendAllLines(path, new[] { $"{method},{migrations},{ms}" });
    }

    private static async Task<long> MeasureAsync(Func<Task> action)
    {
        var sw = Stopwatch.StartNew();
        await action();
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }

    private static void PrintResult(string method, long ms)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{method} completed migration in {ms} ms");
        Console.ResetColor();
    }
    public static async Task RevertLastNAppliedMigrationsAsync(string connectionString, int lastN)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer(connectionString)
            .Options;

        await using var context = new AppDbContext(options);

        var applied = (await context.Database.GetAppliedMigrationsAsync()).ToList();

        if (applied.Count == 0 || lastN <= 0)
        {
            Console.WriteLine("No migrations to revert.");
            return;
        }
        lastN = Math.Min(lastN, applied.Count);

        string targetMigration = lastN == applied.Count
            ? applied.First() 
            : applied[applied.Count - lastN - 1];
       
        Console.WriteLine($"Reverting last {lastN} migrations to '{targetMigration}'...");

        await context.Database.MigrateAsync(targetMigration);

        Console.WriteLine("Done reverting migrations.");
    }
}