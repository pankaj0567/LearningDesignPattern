using System;
using System.Collections.Generic;

namespace LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Example1
{
    // client
    public class ProgramInterpreterExample1
    {
        public void FormatDateInterpreter()
        {
            var expression = new List<IAbstractExpression>();
            var context = new Context(DateTime.Now);
            Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");

            context.Expression = Console.ReadLine();

            expression.Add(new YearExpression());
            expression.Add(new MonthExpression());
            expression.Add(new DayExpression());
            expression.Add(new SeparatorExpression());

            foreach (var exp in expression)
            {
                exp.Evaluate(context);
            }

            Console.WriteLine(context.Expression);
        }
    }
}
