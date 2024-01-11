using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Order
{
    public abstract class PaymentMethod
    {
        protected string HolderName { get; private set;}

        public PaymentMethod(string holderName)
        {
            HolderName = holderName;
        }

        public abstract void ProcessPayment(double amount);

        public virtual bool ValidatePaymentMethod(double amount)
        {
            return true;
        }
    }
}
