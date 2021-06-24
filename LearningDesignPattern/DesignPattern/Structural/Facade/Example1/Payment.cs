using System;

namespace LearningDesignPattern.DesignPattern.Structural.Facade.Example1
{
    // subsystem
    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }
}
