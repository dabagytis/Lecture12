using Lecture12_2.Core.Contracts;
using Lecture12_2.Core.Models;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Lecture12_2;

public class Program
{
    public static void Main(string[] args)
    {
        IPaymentProcessor paypalPayment = new PaypalPayment();
        IPaymentProcessor creditCardPayment = new CreditCardPayment();

        decimal kaina = 30;
        Console.WriteLine($"Price: {kaina}eur. Please choose payment method:");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. Paypal");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                creditCardPayment.ProcessPayment(kaina);
                break;

            case 2:
                paypalPayment.ProcessPayment(kaina);
                break;
 
        }
    }
}