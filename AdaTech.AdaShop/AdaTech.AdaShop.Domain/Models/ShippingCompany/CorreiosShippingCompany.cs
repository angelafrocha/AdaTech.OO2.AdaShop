using AdaTech.AdaShop.Domain.Contracts;
using AdaTech.AdaShop.Domain.Models.Order;

namespace AdaTech.AdaShop.Domain.Models.ShippingCompany
{
    public class CorreiosShippingCompany : Contracts.ShippingCompany
    {
        public CorreiosShippingCompany() : base(id: Guid.NewGuid().ToString()) {}

        public override decimal CalculeShipping(OrderAggregate order)
        {
            return order.OrderItem.Count * 10;
        }

        public override string TrackPackage(string trackingNumber)
        {
            throw new NotImplementedException();
        }
    }
}
