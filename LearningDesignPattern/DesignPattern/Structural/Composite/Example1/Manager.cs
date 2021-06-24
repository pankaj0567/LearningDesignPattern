using System;
using System.Collections.Generic;

namespace LearningDesignPattern.DesignPattern.Structural.Composite.Example1
{
    // composite
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<IEmployee> SubOrdinates;

        public Manager(string name, string dept)
        {
            Name = name;
            Department = dept;
            SubOrdinates = new List<IEmployee>();
        }

        public void GetDetails(int indentation)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("{0}+ Name:{1}, " +
                "Dept:{2} - Manager(Composite)",
                new String('-', indentation), this.Name.ToString(),
                this.Department));

            foreach (var emp in SubOrdinates)
            {
                emp.GetDetails(indentation + 1);
            }
        }
    }
}
