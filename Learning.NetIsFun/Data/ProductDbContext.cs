using Learning.NetIsFun.Models;
using Microsoft.EntityFrameworkCore;

namespace Learning.NetIsFun.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductModel> Product { get; set; }
    }
}