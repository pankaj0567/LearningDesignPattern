using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Builder.Example2
{
    public class ProgramBuilderExample2
    {
        /// <summary>
        /// Fluent Builder Inheritance without Recursive Generics
        /// </summary>
        public void FluentBuilderInheritancewithoutRecursiveGenerics()
        {
            //var builder = new PersonJobBuilder();
            //builder.Called("pankaj")
                  //  .WorkAsA("software engineer");
        }


        /// <summary>
        /// Fluent Builder Inheritance with Recursive Generics
        /// </summary>
        public void FluentBuilderInheritancewithRecursiveGenerics()
        {
            var me = Person.New
                           .Called("Pankej")
                           .WorkAsA("Software Engineer")
                           .Build();
            Console.WriteLine(me.ToString());
        }
    }
}
