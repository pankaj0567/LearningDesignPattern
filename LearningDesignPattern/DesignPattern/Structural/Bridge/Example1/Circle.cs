﻿namespace LearningDesignPattern.DesignPattern.Structural.Bridge.Example1
{
    public class Circle : Shape
    {
        private float radius;
        public Circle(IRenderer renderer,float radius): base(renderer)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            renderer.RenderCircle(radius);
        }

        public override void Resize(float factor)
        {
            radius *= factor;
        }
    }
}