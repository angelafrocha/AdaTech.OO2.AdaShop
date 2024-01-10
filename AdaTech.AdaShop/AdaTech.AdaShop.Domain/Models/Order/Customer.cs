using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class Customer : IEntity
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string DefaultPayment { get; private set; }

        public Customer(string name, string adress , string cpf, string email, string defaultPayment)
        {

            ID = Guid.NewGuid().ToString();
            Name = name;
            Address = adress;
            CPF = cpf;
            Email = email;
            DefaultPayment = defaultPayment;
        }
    }

}