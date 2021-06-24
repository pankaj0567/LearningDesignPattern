using System;

namespace LearningDesignPattern.DesignPattern.Structural.Adapter.Example1
{
    public class ProgramAdapterExample1
    {
        private readonly ILumiaXMLTarget lumiaXMLTarget;

        public ProgramAdapterExample1(ILumiaXMLTarget lumiaXMLTarget)
        {
            this.lumiaXMLTarget = lumiaXMLTarget;
        }
        
        public void JsonToXmlConverterWithAdapter()
        {
            var xml = lumiaXMLTarget.GetLumiaMobilesXMLSpecifications();
            Console.WriteLine(xml.OuterXml);
        }
    }
}
