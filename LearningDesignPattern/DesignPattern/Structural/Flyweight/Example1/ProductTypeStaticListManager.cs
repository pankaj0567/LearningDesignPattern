using System.Collections.Generic;

namespace LearningDesignPattern.DesignPattern.Structural.Flyweight.Example1
{
    // Concrete Flyweight
    public class ProductTypeStaticListManager : IFlyWeightManager
    {
        private List<StaticItem> StaticItemList;

        public ProductTypeStaticListManager()
        {
            StaticItemList = new List<StaticItem>();
        }

        public List<StaticItem> GetList()
        {
            StaticItemList.Add(new StaticItem { id = 1, Code = "0123", Description = "Watch" });
            StaticItemList.Add(new StaticItem { id = 2, Code = "0234", Description = "Shoes" });
            StaticItemList.Add(new StaticItem { id = 3, Code = "0345", Description = "" });
            return StaticItemList;
        }
    }
}
