using Microsoft.EntityFrameworkCore;
using EFCoreMySql.Models;

namespace EFCoreMySql.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;port=3306;user=root;password=Bobfishing2314_door;database=EFCOREDB";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
