using Microsoft.EntityFrameworkCore;
using MigrationAnalysing;
using MigrationAnalysing.Benchmark;
using MigrationAnalysing.DataAccess;
using System.Diagnostics;

var totalSw = Stopwatch.StartNew();

var builder = WebApplication.CreateBuilder(args);

if (args.Contains("--benchmark"))
{
    var mode = args.SkipWhile(a => a != "--benchmark").Skip(1).FirstOrDefault() ?? "bundle";
    var conn = builder.Configuration.GetConnectionString("MSSQL_Conn")
               ?? "Server=localhost;Database=MigrationBenchDb;Trusted_Connection=True;TrustServerCertificate=True;";

    await BenchmarkRunner.RunAsync(mode, conn);
    return;
}

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseModel(AppDbContextModel.Instance);
    options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL_Conn"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await db.Database.MigrateAsync();
}
totalSw.Stop();
Console.WriteLine($"[Startup] EF Migrations applied in {totalSw.ElapsedMilliseconds} ms");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
