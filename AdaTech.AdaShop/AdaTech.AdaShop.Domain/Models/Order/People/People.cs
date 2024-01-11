using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order.People
{
    public abstract class People
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }

        public People(string name, string adress, string cpf, string email)
        {
            Name = name;
            Address = adress;
            CPF = cpf;
            Email = email;
        }
    }
}
