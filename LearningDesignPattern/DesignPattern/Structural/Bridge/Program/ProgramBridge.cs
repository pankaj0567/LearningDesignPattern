using LearningDesignPattern.DesignPattern.Structural.Bridge.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Structural.Bridge.Program
{
    public class ProgramBridge
    {
        public static void Run()
        {
            #region Example 1
            var bridge = new ProgramBridgeExample1();
            Console.WriteLine("bridge pattern example 1 start");
            Console.WriteLine();
            bridge.DrawCircleWithDifferentRenderer();
            Console.WriteLine();
            Console.WriteLine("bridge pattern example 1 end");
            #endregion
        }
    }
}
