using StrategyPattern;

class Program
{
    static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        // Use Credit Card strategy
        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout(100);

        // Switch to PayPal strategy
        cart.SetPaymentStrategy(new PayPalPayment());
        cart.Checkout(200);
    }
}