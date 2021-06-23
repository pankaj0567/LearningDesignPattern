using LearningDesignPattern.DesignPattern.Creational.Singleton.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Creational.Singleton.Program
{
    public class ProgramSingleton
    {
        public static void Run()
        {
            #region Example 1
            var program1 = new ProgramSingletonExample1();
            Console.WriteLine("Singleton Start");
            Console.WriteLine("");
            program1.Singleton();
            Console.WriteLine("");
            Console.WriteLine("Singleton End");
            #endregion
        }
    }
}
