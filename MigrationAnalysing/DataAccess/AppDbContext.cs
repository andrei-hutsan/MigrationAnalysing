using Microsoft.EntityFrameworkCore;
using MigrationAnalysing.Models;

namespace MigrationAnalysing.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Model1> Model1 => Set<Model1>();
    }
}
