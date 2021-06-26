namespace LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Example1
{
    public class MonthExpression : IAbstractExpression
    {
        public void Evaluate(Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("MM", context.date.Month.ToString());
        }
    }
}
