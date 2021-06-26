using System;

namespace LearningDesignPattern.DesignPattern.Behavioral.Interpreter.Example1
{
    public class Context
    {
        public string Expression { get; set; }
        public DateTime date { get; set; }
        public Context(DateTime date)
        {
            this.date = date;
        }
    }
}
