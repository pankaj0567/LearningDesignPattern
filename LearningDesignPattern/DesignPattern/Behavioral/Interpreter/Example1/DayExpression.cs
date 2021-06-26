namespace LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Example1
{
    public class DayExpression : IAbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("DD", context.date.Day.ToString());
        }
    }
}
