using LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Program
{
    public class ProgramInterpreter
    {
        public static void Run()
        {
            #region Example 1
            var program1 = new ProgramInterpreterExample1();
            Console.WriteLine("Interpreter design pattern example 1 start");
            Console.WriteLine("");
            program1.FormatDateInterpreter();
            Console.WriteLine("");
            Console.WriteLine("Interpreter design pattern example 1 end");
            #endregion
        }
    }
}
