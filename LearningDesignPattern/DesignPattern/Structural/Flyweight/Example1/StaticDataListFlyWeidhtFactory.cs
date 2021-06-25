using System.Collections.Generic;
using System.Linq;

namespace LearningDesignPattern.DesignPattern.Structural.Flyweight.Example1
{
    // Flyweight Factory
    public class StaticDataListFlyWeidhtFactory
    {
        private static readonly Dictionary<string, List<StaticItem>> data = new Dictionary<string, List<StaticItem>>();
        public static List<StaticItem> GetStaticItemList(string key)
        {
            IFlyWeightManager manager = null;

            if (key == "Country")
            {
                if (data.Any(d => d.Key == "Country"))
                {
                    return data.First(d => d.Key == "Country").Value;
                }
                else
                {
                    manager = new CountryStaticListManager();
                }
            }
            else if (key == "ProductType")
            {
                if (data.Any(d => d.Key == "ProductType"))
                {
                    return data.First(d => d.Key == "ProductType").Value; ;
                }
                else
                {
                    manager = new ProductTypeStaticListManager();
                }
            }

            var list = manager.GetList();
            data.Add(key, list);
            return list;
        }
    }
}
