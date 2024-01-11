using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order.Payment
{
    public class DebitCard : PaymentMethod
    {
        public string CardNumber { get; private set; }
        public string ExpiryDate { get; private set; }
        public string SecurityCode { get; private set; }

        public DebitCard(string holderName, string cardNumber, string expiryDate, string securityCode)
          : base(holderName)
        {
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
            SecurityCode = securityCode;
        }

        public override void ProcessPayment(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
