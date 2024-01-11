using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order.Payment
{
    public class CreditCard : PaymentMethod
    {
        public string CardNumber { get; private set; }
        public string ExpiryDate { get; private set; }
        public string SecurityCode { get; private set; }
        public string Installment { get; private set; }

        public CreditCard(string holderName, string cardNumber, string expiryDate, string securityCode, string installment)
          : base(holderName)
        {
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
            SecurityCode = securityCode;
            Installment = installment;
        }

        public override void ProcessPayment(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
