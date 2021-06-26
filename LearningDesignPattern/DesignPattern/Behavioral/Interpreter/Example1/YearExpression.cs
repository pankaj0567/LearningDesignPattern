namespace LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Example1
{
    public class YearExpression : IAbstractExpression
    {
        public void Evaluate(Context context)
        {
            var expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.date.Year.ToString());
        }
    }
}
