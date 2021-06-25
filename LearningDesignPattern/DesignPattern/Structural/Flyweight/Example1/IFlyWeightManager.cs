using System.Collections.Generic;

namespace LearningDesignPattern.DesignPattern.Structural.Flyweight.Example1
{
    // Flyweight
    public interface IFlyWeightManager
    {
        List<StaticItem> GetList();
    }
}
