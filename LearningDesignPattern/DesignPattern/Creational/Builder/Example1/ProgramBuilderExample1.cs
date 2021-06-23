using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Builder.Example1
{
    public class ProgramBuilderExample1
    {
        /// <summary>
        /// Create html object without builder pattern
        /// </summary>
        public void HtmlObjectWithoutBuilderPattern()
        {
            Console.WriteLine("html object without builder pattern Start");
            Console.WriteLine("");
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);

            var words = new string[] { "Hello", "World" };
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat($"<li>{word}</li>");
            }
            sb.Append("</ul>");
            Console.WriteLine(sb.ToString());


            Console.WriteLine("");
            Console.WriteLine("html object without builder pattern End");
        }

        /// <summary>
        /// Create html object with builder pattern
        /// </summary>
        public void HtmlObjectWithBuilderPattern()
        {
            var builder = new HTMLBuilder("ul");
            builder.AddChild("li", "Hello")
                   .AddChild("li", "World");
            Console.WriteLine(builder.ToString());
        }


    }
}
