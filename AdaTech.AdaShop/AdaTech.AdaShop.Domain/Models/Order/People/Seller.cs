using AdaTech.AdaShop.Domain.Contracts;
using AdaTech.AdaShop.Domain.Models.Order.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order.People
{
    internal class Seller : Employee
    {
        public Seller(string name, string address, string CPF, string email) : base(name, address, CPF, email)
        {
        }

        public override decimal CalculateComission()
        {
            throw new NotImplementedException();
        }

        public List<OrderAggregate> orderAggregates()
        {
            return new List<OrderAggregate>();  
        }

        public bool CreateOrderAggreate(Customer custumer, List<OrderItem> orderItems, InfoPayments infoPayments, ShippingCompany shippingCompany)
        {
            var orderAggregate = new OrderAggregate(custumer, shippingCompany);
            orderAggregate.OrderItem = orderItems;
            orderAggregate.InfoPayments = infoPayments;
            orderAggregate.Employee = this;
            return false;
        }
    }
}
