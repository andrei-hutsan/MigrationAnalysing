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
                Console.WriteLine("== Benchmark: NonCompiled Models OnStartup Migration (Cold vs Warm Average) ==");

                var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(connection)
                    .Options;

                await ColdVsWarm(options);

                break;

            case "precompiled":
                Console.WriteLine("== Benchmark: PreCompiled Models OnStartup Migration (Cold vs Warm Average) ==");

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

        var warmTimes = new List<long>();
        for (int i = 0; i < 10; i++)
        {
            var time = await MeasureAsync(async () =>
            {
                await using var ctx = new AppDbContext(options);
                await ctx.Database.MigrateAsync();
            });
            warmTimes.Add(time);
            Console.WriteLine($"Warm run {i + 1}: {time} ms");
        }

        long warmAvg = (long)warmTimes.Average();

        Log("OnStartup-Cold", migrationCount, coldElapsed, resultPath);
        Log("OnStartup-WarmAvg", migrationCount, warmAvg, resultPath);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Cold migration (first run): {coldElapsed} ms");
        Console.WriteLine($"Average warm migration (cached model): {warmAvg} ms");
        Console.WriteLine($"Startup caching gain: {coldElapsed - warmAvg} ms");
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
        Console.WriteLine($"{method} completed migration in {ms}");
    }
}
