using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Prototype.Example1
{
    public class ProgramPrototypeExample1
    {
        public void Prototype()
        {
            var pankaj = new Person("pankaj", new Address("123", "Delhi", "India"));
            var sahil = pankaj.DeepCopyXml();
            sahil.Name = "Sahil";
            sahil.Address.Country = "US";

            Console.WriteLine(pankaj);
            Console.WriteLine(sahil);

        }
    }
}
