using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPattern.DesignPattern.Creational.Singleton.Example1
{
    public sealed class EmployeeDatabase : IDatabase<Employee>
    {
        private readonly List<Employee> _employees;
        private static readonly Lazy<EmployeeDatabase> lazy =
                        new Lazy<EmployeeDatabase>(() => new EmployeeDatabase());
        public static IDatabase<Employee> Instance { get { return lazy.Value; } }

        private EmployeeDatabase()
        {
            _employees  = new List<Employee>();
        }
        public void Add(Employee model)
        {
            _employees.Add(model);
        }

        public void Remove(Employee model)
        {
            var deleteEmployee = _employees.Find(e => e.Name == model.Name);
            _employees.Remove(deleteEmployee);
        }

        public void Show()
        {
            foreach (var e in _employees)
            {
                Console.WriteLine($"Employe Name : {e.Name}");
            }
        }
    }
}
