using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public class Customer : People, IEntity
    {
        public string ID { get; private set; }

        public Customer(string name, string address , string CPF, string email)
            :base(name, address, CPF, email)
        {
            ID = Guid.NewGuid().ToString();

        }
    }

}