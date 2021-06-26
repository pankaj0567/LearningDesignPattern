using LearningDesignPattern.DesignPattern.Behavioral.Command.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Behavioral.Command.Program
{
    public class ProgramCommand
    {
        public static void Run()
        {
            #region Example 1
            var command1 = new ProgramCommandExample1();
            Console.WriteLine("Command design pattern example 1 start");
            Console.WriteLine("");
            command1.UndoInTransactionOfBankCommand();
            Console.WriteLine("");
            Console.WriteLine("Command design pattern example 1 end");
            #endregion
        }
    }
}
