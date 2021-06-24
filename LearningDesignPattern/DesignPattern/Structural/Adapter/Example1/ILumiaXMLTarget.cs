using System.Xml;

namespace LearningDesignPattern.DesignPattern.Structural.Adapter.Example1
{
    /// Target
    public interface  ILumiaXMLTarget
    {
        XmlDocument GetLumiaMobilesXMLSpecifications();
    }
}
