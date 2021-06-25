using System.Collections.Generic;

namespace LearningDesignPattern.DesignPattern.Structural.Flyweight.Example1
{
    // Concrete Flyweight
    public class CountryStaticListManager : IFlyWeightManager
    {
        private readonly List<StaticItem> StaticItemList;
        public CountryStaticListManager()
        {
            StaticItemList = new List<StaticItem>();
        }

        public List<StaticItem> GetList()
        {
            StaticItemList.Add(new StaticItem { id = 1, Code = "IND", Description = "India" });
            StaticItemList.Add(new StaticItem { id = 2, Code = "SRL", Description = "Sri Lanka" });
            StaticItemList.Add(new StaticItem { id = 3, Code = "SA", Description = "South Africa" });
            return StaticItemList;
        }
    }
}
