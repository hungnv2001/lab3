using Microsoft.EntityFrameworkCore;

namespace Bai1.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        protected MyContext()
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<ProductViewModel> ProductViewModels { get; set; }
    }
}
