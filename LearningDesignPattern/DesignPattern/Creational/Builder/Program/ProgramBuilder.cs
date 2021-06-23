using LearningDesignPattern.DesignPattern.Creational.Builder.Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Builder.Program
{
    public class ProgramBuilder
    {
        public  static void Run()
        {
            #region Example 1
            Console.WriteLine("Example 1 Start");
            /// Example 1 of builder Pattern
            ProgramBuilderExample1 programBuilder = new ProgramBuilderExample1();
            programBuilder.HtmlObjectWithoutBuilderPattern();
            Console.WriteLine("html object with builder pattern Start");
            programBuilder.HtmlObjectWithBuilderPattern();
            Console.WriteLine("html object with builder pattern End");
            Console.WriteLine("Example 1 End");
            #endregion

        }
    }
}
