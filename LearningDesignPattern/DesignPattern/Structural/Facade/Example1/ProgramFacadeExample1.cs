using System;

namespace LearningDesignPattern.DesignPattern.Structural.Facade.Example1
{
    // client
    public class ProgramFacadeExample1
    {
        public void FacadeClient()
        {
            var order = new Order();
            order.PlaceOrder();
        }
    }
}
