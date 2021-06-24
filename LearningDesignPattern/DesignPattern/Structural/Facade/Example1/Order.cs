using System;

namespace LearningDesignPattern.DesignPattern.Structural.Facade.Example1
{
    // facade
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            var product = new Product();
            product.GetProductDetails();
            var payment = new Payment();
            payment.MakePayment();
            var invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}
