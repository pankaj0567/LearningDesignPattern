using System;

namespace LearningDesignPattern.DesignPattern.Creational.Prototype.Example1
{
    public class Person
    {
        public string Name;
        public Address Address;

        public Person()
        {

        }

        public Person(string name, Address address)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Address = address ?? throw new ArgumentNullException(paramName: nameof(address));
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}";
        }
    }
}
