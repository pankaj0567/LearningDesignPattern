using System;
using System.Collections.Generic;

namespace LearningDesignPattern.DesignPattern.Structural.Flyweight.Example1
{
    // Client
    public class ProgramFlyweightExample1
    {
        public void FlyweightInCountryDataAndProductType()
        {
            List<StaticItem> countrylist = StaticDataListFlyWeidhtFactory.GetStaticItemList("Country");
            foreach (var item in countrylist)
            {
                Console.WriteLine(item.id.ToString() + "  " + item.Code + "  " + item.Description);
            }
        }
    }
}
