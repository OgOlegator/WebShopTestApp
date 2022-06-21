using System.Collections.Generic;
using ShopTobaccoWebApp.Domain.Entities;
using ShopTobaccoWebApp.Domain.Abstract;

namespace ShopTobaccoWebApp.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
