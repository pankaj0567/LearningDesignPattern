namespace LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Example1
{
    public class SeparatorExpression : IAbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}
