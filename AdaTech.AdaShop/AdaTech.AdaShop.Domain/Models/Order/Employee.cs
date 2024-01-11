using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    //Emploee herda de uma interface IEntity, logo é obrigado a seguir o contrato de IEntity.
    //Ou seja, deve implementar os métodos e propriedade da interface IEntity
    public class Employee : People, IEntity
    {
        public string ID { get; private set; }

        public Employee(string name, string address, string CPF, string email)
          : base(name, address, CPF, email)
        {
            ID = Guid.NewGuid().ToString();
        }

        
    }
}