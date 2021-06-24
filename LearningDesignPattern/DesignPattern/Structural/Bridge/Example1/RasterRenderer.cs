using System;

namespace LearningDesignPattern.DesignPattern.Structural.Bridge.Example1
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing pixels for circle with radius {radius}");
        }
    }
}
