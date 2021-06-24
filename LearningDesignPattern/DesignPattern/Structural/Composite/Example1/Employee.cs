using System;

namespace LearningDesignPattern.DesignPattern.Structural.Composite.Example1
{
    // Leaf
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name,string dept)
        {
            Name = name;
            Department = dept;
        }

        public void GetDetails(int indentation)
        {
            var indent = new string('-', indentation);
            Console.WriteLine($"{indent}-Name: {Name}, Dept: {Department} (Leaf)");
        }
    }
}
