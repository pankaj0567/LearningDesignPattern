using LearningDesignPattern.DesignPattern.Creational.Prototype.Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Prototype.Program
{
    public class ProgramPrototype
    {
        public static void Run()
        {
            #region Example 1
            Console.WriteLine("Prototype start");
            Console.WriteLine("");
            var program1 = new ProgramPrototypeExample1();
            program1.Prototype();
            Console.WriteLine("");
            Console.WriteLine("Prototype End");
            #endregion
        }
    }
}
