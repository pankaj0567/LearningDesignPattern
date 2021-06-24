using LearningDesignPattern.DesignPattern.Structural.Adapter.Example1;
using System;

namespace LearningDesignPattern.DesignPattern.Structural.Adapter.Program
{
    public class ProgramAdapter
    {
        public static void Run()
        {
            #region Example 1
            var adapter = new ProgramAdapterExample1(new LumiaXMLAdapter());
            Console.WriteLine("Adapter design pattern example 1 start");
            Console.WriteLine("");
            adapter.JsonToXmlConverterWithAdapter();
            Console.WriteLine("");
            Console.WriteLine("Adapter design pattern example 1 end");
            #endregion
        }
    }
}
