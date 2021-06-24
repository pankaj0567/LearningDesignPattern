using System;

namespace LearningDesignPattern.DesignPattern.Structural.Bridge.Example1
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius}");
        }
    }
}
