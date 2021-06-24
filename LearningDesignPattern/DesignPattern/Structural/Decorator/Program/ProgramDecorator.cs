using LearningDesignPattern.DesignPattern.Structural.Decorator.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Structural.Decorator.Program
{
    public class ProgramDecorator
    {
        public static void Run()
        {
            #region Example 1 
            var Decorator1 = new ProgramDecoratorExample1();
            Console.WriteLine("Decorator pattern example 1 start");
            Console.WriteLine();
            Decorator1.ExtentedCarComponentWithDecorator();
            Console.WriteLine();
            Console.WriteLine("Decorator pattern example 1 end");
            #endregion
        }
    }
}
