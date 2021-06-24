namespace LearningDesignPattern.DesignPattern.Structural.Decorator.Example1
{
    // Decorator
    public abstract class CarDecorator : ICar
    {
        private readonly ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public string Make => car.Make;

        public double GetPrice()
        {
            return car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}
