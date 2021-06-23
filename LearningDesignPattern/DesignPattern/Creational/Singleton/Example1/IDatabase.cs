using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Singleton.Example1
{
    public interface IDatabase<T>
    {
        void Add(T model);
        void Remove(T model);
        void Show();
    }
}
