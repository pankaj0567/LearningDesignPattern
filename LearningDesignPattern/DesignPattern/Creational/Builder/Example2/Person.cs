using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Builder.Example2
{
    public class Person
    {
        public string Name;
        public string Position;
        public static Builder New => new Builder();

        public class Builder : PersonJobBuilder<Builder>
        {

        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name},{nameof(Position)}: {Position}";
        }
    }
}
