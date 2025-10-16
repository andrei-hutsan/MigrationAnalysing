using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
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

        long elapsed = 0;

        switch (mode.ToLower())
        {
            case "migrate":
                await DropDatabase(connection);
                elapsed = await MeasureAsync(async () =>
                {
                    using var ctx = new AppDbContext(
                        new DbContextOptionsBuilder<AppDbContext>()
                            .UseSqlServer(connection)
                            .Options);
                    await ctx.Database.MigrateAsync();
                });
                Log("MigrateOnStartup", migrationCount, elapsed, resultPath);
                break;

            case "sql":
                await DropDatabase(connection);
                var scriptPath = Path.Combine("artifacts", $"script_{migrationCount}.sql");
                if (!File.Exists(scriptPath))
                    throw new FileNotFoundException(scriptPath);
                elapsed = await MeasureAsync(async () =>
                {
                    string sql = await File.ReadAllTextAsync(scriptPath);
                    using var conn = new SqlConnection(connection);
                    await conn.OpenAsync();
                    using var cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.CommandTimeout = 0;
                    await cmd.ExecuteNonQueryAsync();
                });
                Log("CachedSQL", migrationCount, elapsed, resultPath);
                break;

            case "bundle":
                await DropDatabase(connection);
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
                break;


            default:
                Console.WriteLine("Invalid benchmark mode. Use migrate | sql | bundle");
                return;
        }

        Console.WriteLine($"{mode} completed in {elapsed} ms");
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

    private static async Task DropDatabase(string connection)
    {
        var builder = new SqlConnectionStringBuilder(connection);
        var dbName = builder.InitialCatalog;
        builder.InitialCatalog = "master";

        using var conn = new SqlConnection(builder.ToString());
        await conn.OpenAsync();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = $@"
IF DB_ID('{dbName}') IS NOT NULL
BEGIN
    ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [{dbName}];
END";
        await cmd.ExecuteNonQueryAsync();
    }
}
