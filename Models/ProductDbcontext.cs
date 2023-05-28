using Microsoft.EntityFrameworkCore;

namespace MVCbPractice.Models
{
    public class ProductDbcontext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}
