using System;

namespace StrategyPattern
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid " + amount + " using Credit Card.");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Paid " + amount + " using PayPal.");
        }
    }

    public class ShoppingCart
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }

        public void Checkout(decimal amount)
        {
            if (paymentStrategy == null)
            {
                Console.WriteLine("No payment method selected.");
            }
            else
            {
                paymentStrategy.Pay(amount);
            }
        }
    }    
}