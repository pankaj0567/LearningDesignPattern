using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Builder.Example1
{
    /// <summary>
    /// This class is used to create html object
    /// </summary>
    public class HTMLBuilder
    {
        private readonly string _rootName;
        HTMLElement root = new HTMLElement();
        public HTMLBuilder(string rootName)
        {
            _rootName = rootName;
            root.Name = rootName;
        }

        /// <summary>
        /// This method is used to add child in root node.
        /// </summary>
        /// <param name="childName">This is the Name of HTML Element</param>
        /// <param name="childText">This is the Text of HTML Element</param>
        /// <returns></returns>
        public HTMLBuilder AddChild(string childName,string childText)
        {
            var e = new HTMLElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        /// <summary>
        /// Clear the children of room elements
        /// </summary>
        public void Clear()
        {
            root = new HTMLElement { Name = _rootName };
        }
    }
}
