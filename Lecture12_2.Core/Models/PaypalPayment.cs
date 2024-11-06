using Lecture12_2.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12_2.Core.Models
{
    public class PaypalPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"You've paid {amount}eur (Paypal payment)");
        }
    }
}
