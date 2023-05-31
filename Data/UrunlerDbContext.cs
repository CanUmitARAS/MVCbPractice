using Microsoft.EntityFrameworkCore;
using MVCbPractice.Models;

namespace MVCbPractice.Data
{
    public class UrunlerDbContext : DbContext
    {
        public UrunlerDbContext(DbContextOptions<UrunlerDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Burada model özelleştirmelerini yapabilirsiniz, ancak şu an için herhangi bir özelleştirme yapmayacağız.
        }
    }
}
