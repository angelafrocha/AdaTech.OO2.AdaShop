using AdaTech.AdaShop.Domain.Contracts;

namespace AdaTech.AdaShop.Domain.Models.Order.People
{
    //Emploee herda de uma interface IEntity, logo é obrigado a seguir o contrato de IEntity.
    //Ou seja, deve implementar os métodos e propriedade da interface IEntity
    public abstract class Employee : People, IEntity
    {
        public string ID { get; private set; }

        public Employee(string name, string address, string CPF, string email)
          : base(name, address, CPF, email)
        {
            ID = Guid.NewGuid().ToString();
        }

        public abstract decimal CalculateComission();
    }
}