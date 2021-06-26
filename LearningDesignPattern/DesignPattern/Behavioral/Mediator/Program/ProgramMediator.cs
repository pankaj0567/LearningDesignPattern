using LearningDesignPattern.DesignPattern.Behavioral.Mediator.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Behavioral.Mediator.Program
{
    public class ProgramMediator
    {
        public static void Run()
        {
            #region Example 1
            var program1 = new ProgramMediatorExample1();
            Console.WriteLine("Mediator design pattern example 1 start");
            Console.WriteLine("");
            program1.ChatApp();
            Console.WriteLine("");
            Console.WriteLine("Mediator design pattern example 1 end");
            #endregion
        }
    }
}
