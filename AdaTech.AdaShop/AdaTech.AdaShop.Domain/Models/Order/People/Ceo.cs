using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order.People
{
    internal class Ceo : Employee
    {
        public Ceo(string name, string address, string CPF, string email) : base(name, address, CPF, email)
        {
        }

        public override decimal CalculateComission()
        {
            throw new NotImplementedException();
        }

        public List<OrderAggregate> OrderAggregates() { 
            return new List<OrderAggregate>();
        }

        public List<Employee> Employees()
        {
            return new List<Employee>();
        }
         
    }
}
