using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using MigrationAnalysing.DataAccess;

namespace MigrationAnalysing.Benchmark;

public static class BenchmarkRunner
{
    private static int migrationCount = 200;
    private static string resultPath = Path.Combine("artifacts", "results.csv");
    public static async Task RunAsync(string mode, string connection)
    {
        Directory.CreateDirectory("artifacts");

        if (!File.Exists(resultPath))
            File.WriteAllText(resultPath, "Method,MigrationCount,Milliseconds\n");

        Console.WriteLine($"== Running benchmark: {mode} ==");

        long elapsed;

        switch (mode.ToLower())
        {
            case "onstartup":
                Console.WriteLine("== Benchmark: NonCompiled Models OnStartup Migration (Cold vs Warm) ==");

                var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(connection)
                    .Options;

                await ColdVsWarm(options);

                break;


            case "bundle":
                var bundlePath = Path.Combine("artifacts", $"bundle_{migrationCount}.exe");

                if (!File.Exists(bundlePath))
                    throw new FileNotFoundException(bundlePath);

                elapsed = await MeasureAsync(async () =>
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
                    Console.WriteLine(error);
                });
                Log("Bundle", migrationCount, elapsed, resultPath);
                PrintResult("Bundle", elapsed);
                break;


            case "precompiled":
                Console.WriteLine("== Benchmark: PreCompiled Models OnStartup Migration (Cold vs Warm) ==");

                var opts = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(connection)
                    .UseModel(AppDbContextModel.Instance)
                    .Options;

                await ColdVsWarm(opts);

                break;


            default:
                Console.WriteLine("Invalid benchmark mode. Use migrate | bundle | precompiled");
                return;
        }
    }

    private static async Task ColdVsWarm(DbContextOptions<AppDbContext> options)
    {
        long coldElapsed = await MeasureAsync(async () =>
        {
            await using var ctx = new AppDbContext(options);
            await ctx.Database.MigrateAsync();
        });


        var warmElapsed = await MeasureAsync(async () =>
        {
            await using var ctx = new AppDbContext(options);
            await ctx.Database.MigrateAsync();
        });


        Log("OnStartup-Cold", migrationCount, coldElapsed, resultPath);
        Log("OnStartup-WarmAvg", migrationCount, warmElapsed, resultPath);

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
}
