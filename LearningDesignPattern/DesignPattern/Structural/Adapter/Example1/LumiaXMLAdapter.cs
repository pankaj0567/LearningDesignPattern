using Newtonsoft.Json;
using System.Xml;

namespace LearningDesignPattern.DesignPattern.Structural.Adapter.Example1
{
    public class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public XmlDocument GetLumiaMobilesXMLSpecifications()
        {
            LumiaJSONAdaptee lumiaJsonAdaptee = new LumiaJSONAdaptee();
            string jsonLumia = lumiaJsonAdaptee.GetLumiaMobilesJSONSpecifications();
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMoblies", true);
            return doc;
        }
    }
}
