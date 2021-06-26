using LearningDesignPattern.DesignPattern.Behavioral.ChainOfResponsibility.Program;
using LearningDesignPattern.DesignPattern.Behavioral.Command.Program;
using LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Program;
using LearningDesignPattern.DesignPattern.Creational.Builder.Program;
using LearningDesignPattern.DesignPattern.Creational.Prototype.Program;
using LearningDesignPattern.DesignPattern.Creational.Singleton.Program;
using LearningDesignPattern.DesignPattern.Structural.Adapter.Program;
using LearningDesignPattern.DesignPattern.Structural.Bridge.Program;
using LearningDesignPattern.DesignPattern.Structural.Composite.Program;
using LearningDesignPattern.DesignPattern.Structural.Decorator.Program;
using LearningDesignPattern.DesignPattern.Structural.Facade.Program;
using LearningDesignPattern.DesignPattern.Structural.Flyweight.Program;
using System;

namespace LearningDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Builder Pattern
            //ProgramBuilder.Run();

            // Protottype pattern
            //ProgramPrototype.Run();

            // Singleton Pattern
            //ProgramSingleton.Run();

            // Adapter
            //ProgramAdapter.Run();

            // Bridge
            //ProgramBridge.Run();

            // Composite
            //ProgramComposite.Run();

            // Decorator
            //ProgramDecorator.Run();

            // Facade
            //ProgramFacade.Run();

            // Flyweight
            //ProgramFlyweight.Run();

            // Chain Of Responsibility
            //ProgramChainOfResponsibility.Run();

            // Command  
            //ProgramCommand.Run();

            // Interpreter
            ProgramInterpreter.Run();

            Console.ReadKey();
        }
    }
}
