using System;

namespace LearningDesignPattern.DesignPattern.Structural.Facade.Example1
{
    // subsystem
    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }
}
