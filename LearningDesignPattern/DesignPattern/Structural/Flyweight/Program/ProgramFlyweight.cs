using LearningDesignPattern.DesignPattern.Structural.Flyweight.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Structural.Flyweight.Program
{
    public class ProgramFlyweight
    {
        public static void Run()
        {
            #region Example 1 
            var Flyweight1 = new ProgramFlyweightExample1();
            Console.WriteLine("Flyweight pattern example 1 start");
            Console.WriteLine();
            Flyweight1.FlyweightInCountryDataAndProductType();
            Console.WriteLine();
            Console.WriteLine("Flyweight pattern example 1 end");
            #endregion
        }
    }
}
