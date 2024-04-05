using Microsoft.EntityFrameworkCore;

namespace TestMediateur.Model
{
    public class IProductsRepo : DbContext
    {
        public IProductsRepo(DbContextOptions<IProductsRepo> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
