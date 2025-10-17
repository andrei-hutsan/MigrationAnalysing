using Microsoft.EntityFrameworkCore;
using MigrationAnalysing.DataAccess;
using MigrationAnalysing.Benchmark;

var builder = WebApplication.CreateBuilder(args);

// === Detect Benchmark Flag ===
if (args.Contains("--benchmark"))
{
    var mode = args.SkipWhile(a => a != "--benchmark").Skip(1).FirstOrDefault() ?? "migrate";
    var conn = builder.Configuration.GetConnectionString("MSSQL_Conn")
               ?? "Server=localhost;Database=MigrationBenchDb;Trusted_Connection=True;TrustServerCertificate=True;";

    await BenchmarkRunner.RunAsync(mode, conn);
    return;
}

// === Normal web app setup ===
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL_Conn")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
