using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using MigrationAnalysing.DataAccess;

namespace MigrationAnalysing.Benchmark;

public static class BenchmarkRunner
{
    public static async Task RunAsync(string mode, string connection, int migrationCount = 100)
    {
        Directory.CreateDirectory("artifacts");
        string resultPath = Path.Combine("artifacts", "results.csv");
        if (!File.Exists(resultPath))
            File.WriteAllText(resultPath, "Method,MigrationCount,Milliseconds\n");

        Console.WriteLine($"== Running benchmark: {mode} ==");

        long elapsed;

        switch (mode.ToLower())
        {
            case "onstartup":
                elapsed = await MeasureAsync(async () =>
                {
                    using var ctx = new AppDbContext(
                        new DbContextOptionsBuilder<AppDbContext>()
                            .UseSqlServer(connection)
                            .Options);
                    await ctx.Database.MigrateAsync();
                });
                Log("MigrateOnStartup", migrationCount, elapsed, resultPath);
                PrintResult("MigrateOnStartup", elapsed);
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


            default:
                Console.WriteLine("Invalid benchmark mode. Use migrate | sql | bundle");
                return;
        }
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
