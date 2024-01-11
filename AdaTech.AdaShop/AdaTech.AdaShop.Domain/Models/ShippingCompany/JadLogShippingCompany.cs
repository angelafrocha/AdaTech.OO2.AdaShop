using AdaTech.AdaShop.Domain.Models.Order;

namespace AdaTech.AdaShop.Domain.Models.ShippingCompany
{
    public class JadLogShippingCompany : Contracts.ShippingCompany
    {
        public JadLogShippingCompany() : base(id: Guid.NewGuid().ToString()) { }

        public override decimal CalculeShipping(OrderAggregate order)
        {
            return order.OrderItem.Count * 15;
        }

        public override string TrackPackage(string trackingNumber)
        {
            throw new NotImplementedException();
        }
    }
}
