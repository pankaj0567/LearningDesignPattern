namespace LearningDesignPattern.DesignPattern.Structural.Bridge.Example1
{
    public abstract class Shape
    {
        protected readonly IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}
