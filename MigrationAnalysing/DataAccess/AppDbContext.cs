using Microsoft.EntityFrameworkCore;
using MigrationAnalysing.Models;

namespace MigrationAnalysing.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<Table10> Table10 { get; set; }
        public DbSet<Table9> Table9 { get; set; }
        public DbSet<Table8> Table8 { get; set; }
        public DbSet<Table7> Table7 { get; set; }
        public DbSet<Table6> Table6 { get; set; }
        public DbSet<Table5> Table5 { get; set; }
        public DbSet<Table4> Table4 { get; set; }
        public DbSet<Table3> Table3 { get; set; }
        public DbSet<Table2> Table2 { get; set; }
        public DbSet<Table1> Table1 { get; set; }

    }
}
