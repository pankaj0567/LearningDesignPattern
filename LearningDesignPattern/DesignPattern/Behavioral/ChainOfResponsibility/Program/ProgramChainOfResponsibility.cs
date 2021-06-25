using LearningDesignPattern.DesignPattern.Behavioral.ChainOfResponsibility.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Behavioral.ChainOfResponsibility.Program
{
    class ProgramChainOfResponsibility
    {
        public static void Run()
        {
            #region Example 1
            var ChainOfResponsibility = new ProgramChainOfResponsibilityExample1();
            Console.WriteLine("Chain Of Responsibility design pattern example 1 start");
            Console.WriteLine("");
            ChainOfResponsibility.ATMMachineWithChainOfResponsibility();
            Console.WriteLine("");
            Console.WriteLine("Chain Of Responsibility design pattern example 1 end");
            #endregion
        }
    }
}
