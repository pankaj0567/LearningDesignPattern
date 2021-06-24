namespace LearningDesignPattern.DesignPattern.Structural.Decorator.Example1
{
    // ConcreteComponent
    public sealed class Suzuki : ICar
    {
        public string Make { get { return "Sedan"; } }

        public double GetPrice()
        {
            return 1000000;
        }
    }
}
