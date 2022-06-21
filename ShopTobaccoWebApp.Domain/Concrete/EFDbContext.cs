using ShopTobaccoWebApp.Domain.Entities;
using System.Data.Entity;

namespace ShopTobaccoWebApp.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}