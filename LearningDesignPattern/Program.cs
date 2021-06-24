using LearningDesignPattern.DesignPattern.Creational.Builder.Program;
using LearningDesignPattern.DesignPattern.Creational.Prototype.Program;
using LearningDesignPattern.DesignPattern.Creational.Singleton.Program;
using LearningDesignPattern.DesignPattern.Structural.Adapter.Program;
using System;

namespace LearningDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder Pattern
            //ProgramBuilder.Run();

            // Protottype pattern
            //ProgramPrototype.Run();

            // Singleton Pattern
            //ProgramSingleton.Run();

            // Adapter
            ProgramAdapter.Run();


            Console.ReadKey();
        }
    }
}
