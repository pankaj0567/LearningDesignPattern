using LearningDesignPattern.DesignPattern.Creational.Builder.Example1;
using LearningDesignPattern.DesignPattern.Creational.Builder.Example2;
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

            #region Example 2
            var program2 = new ProgramBuilderExample2();
            Console.WriteLine("Fluent Builder Inheritance without Recursive Generics Start");
            program2.FluentBuilderInheritancewithoutRecursiveGenerics();
            Console.WriteLine("Fluent Builder Inheritance without Recursive Generics End");

            Console.WriteLine("Fluent Builder Inheritance with Recursive Generics Start");
            Console.WriteLine("");
            program2.FluentBuilderInheritancewithRecursiveGenerics();
            Console.WriteLine("");
            Console.WriteLine("Fluent Builder Inheritance with Recursive Generics End");
            #endregion
        }
    }
}
