using System;

namespace LearningDesignPattern.DesignPattern.Structural.Decorator.Example1
{
    // client 
    public class ProgramDecoratorExample1
    {
        public void ExtentedCarComponentWithDecorator()
        {
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine($"Make: {decorator.Make}, Price: {decorator.GetPrice()},  DiscountPrice: {decorator.GetDiscountedPrice()}");
        }
    }
}
