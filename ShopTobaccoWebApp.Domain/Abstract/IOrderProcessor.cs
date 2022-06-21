using ShopTobaccoWebApp.Domain.Entities;

namespace ShopTobaccoWebApp.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}