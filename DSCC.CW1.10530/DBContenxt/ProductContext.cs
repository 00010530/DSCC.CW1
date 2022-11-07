using DSCC.CW1._10530.Model;
using Microsoft.EntityFrameworkCore;

namespace DSCC.CW1._10530.DBContenxt
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
