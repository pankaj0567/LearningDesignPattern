namespace LearningDesignPattern.DesignPattern.Structural.Decorator.Example1
{
    // ConcreteComponent
    public sealed class Hyndai : ICar
    {
        public string Make => "HatchBack";

        public double GetPrice()
        {
            return 800000;
        }
    }
}
