using LearningDesignPattern.DesignPattern.Structural.Facade.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Structural.Facade.Program
{
    public class ProgramFacade
    {
        public static void Run()
        {
            #region Example 1 
            var Facade1 = new ProgramFacadeExample1();
            Console.WriteLine("Facade pattern example 1 start");
            Console.WriteLine();
            Facade1.FacadeClient();
            Console.WriteLine();
            Console.WriteLine("Facade pattern example 1 end");
            #endregion
        }
    }
}
