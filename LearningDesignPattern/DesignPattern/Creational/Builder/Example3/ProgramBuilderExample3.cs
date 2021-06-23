using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Builder.Example3
{
    public class ProgramBuilderExample3
    {
        public void FacetedBuilder()
        {
            var builder = new PersonBuilder();
            Person person = builder
                .Lives
                    .At("123 Colony")
                    .In("Delhi")
                    .WithPostcode("123")
                .Works
                   .At("Pankaj infotech pvt. ltd.")
                   .AsA("Software Engineer")
                   .Earning(10000);

            Console.WriteLine(person);
        }
    }
}
