namespace LearningDesignPattern.DesignPattern.Creational.Singleton.Example1
{
    public class ProgramSingletonExample1
    {
        public void Singleton()
        {
            var db = EmployeeDatabase.Instance;
            db.Add(new Employee { Name = "pankaj" });
            db.Add(new Employee { Name = "Sahil" });

            db.Remove(new Employee { Name = "Sahil" });

            db.Show();
        }
    }
}
