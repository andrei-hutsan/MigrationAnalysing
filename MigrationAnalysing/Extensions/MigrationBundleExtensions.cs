using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MigrationAnalysing.DataAccess;
using System.Diagnostics;

namespace MigrationAnalysing.Extensions
{
    public static class MigrationBundleExtensions
    {
        public static async Task UseAutoMigrationBundleAsync(
            this WebApplicationBuilder builder,
            string connectionName = "MSSQL_Conn")
        {
            Console.WriteLine("=== [Auto-Migration Layer] Checking for pending migrations... ===");

            using var scope = builder.Services.BuildServiceProvider().CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            var pending = await db.Database.GetPendingMigrationsAsync();

            if (!pending.Any())
            {
                Console.WriteLine("No new migrations found. Skipping bundle generation.");
                return;
            }

            Console.WriteLine($"Found {pending.Count()} pending migrations:");
            foreach (var migration in pending)
                Console.WriteLine($"   → {migration}");

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string bundlePath = $"artifacts/migrations_bundle_{pending.Count()}_{timestamp}.exe";

            Directory.CreateDirectory("artifacts");

            Console.WriteLine("Generating EF migrations bundle...");

            var bundleProcess = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"ef migrations bundle --output \"{bundlePath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var gen = Process.Start(bundleProcess)!;
            string genOut = await gen.StandardOutput.ReadToEndAsync();
            string genErr = await gen.StandardError.ReadToEndAsync();
            await gen.WaitForExitAsync();

            Console.WriteLine(genOut);
            if (!string.IsNullOrWhiteSpace(genErr))
                Console.WriteLine($"[ERROR] {genErr}");

            if (!File.Exists(bundlePath))
            {
                Console.WriteLine("Bundle creation failed. Cannot proceed.");
                return;
            }

            Console.WriteLine($"Bundle generated → {bundlePath}");

            Console.WriteLine("Executing migration bundle...");

            var conn = builder.Configuration.GetConnectionString(connectionName)!;

            var runBundle = new ProcessStartInfo
            {
                FileName = bundlePath,
                Arguments = $"--connection \"{conn}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var run = Process.Start(runBundle)!;
            string outText = await run.StandardOutput.ReadToEndAsync();
            string errText = await run.StandardError.ReadToEndAsync();
            await run.WaitForExitAsync();

            Console.WriteLine(outText);
            if (!string.IsNullOrWhiteSpace(errText))
                Console.WriteLine($"[ERROR] {errText}");

            Console.WriteLine("Bundle executed successfully.");
        }
    }
}
