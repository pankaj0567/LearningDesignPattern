using System;

namespace LearningDesignPattern.DesignPattern.Structural.Facade.Example1
{
    // subsystem
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }
}
