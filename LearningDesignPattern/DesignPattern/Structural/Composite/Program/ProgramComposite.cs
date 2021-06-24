using LearningDesignPattern.DesignPattern.Structural.Composite.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Structural.Composite.Program
{
    public class ProgramComposite
    {
        public static void Run()
        {
            #region Example 1 
            var composite1 = new ProgramCompositeExample1();
            Console.WriteLine("Composite pattern example 1 start");
            Console.WriteLine();
            composite1.Companyhierarchy();
            Console.WriteLine();
            Console.WriteLine("Composite pattern example 1 end");
            #endregion
        }
    }
}
