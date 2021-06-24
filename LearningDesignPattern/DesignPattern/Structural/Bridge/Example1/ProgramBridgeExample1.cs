namespace LearningDesignPattern.DesignPattern.Structural.Bridge.Example1
{
    public class ProgramBridgeExample1
    {
        public void DrawCircleWithDifferentRenderer() {
            var circle = new Circle(new RasterRenderer(),5);
            circle.Draw();
            circle.Resize(2);
            circle.Draw();

            var vectorCircle = new Circle(new VectorRenderer(), 7);
            vectorCircle .Draw();
            vectorCircle .Resize(2);
            vectorCircle.Draw();
        }
    }
}
