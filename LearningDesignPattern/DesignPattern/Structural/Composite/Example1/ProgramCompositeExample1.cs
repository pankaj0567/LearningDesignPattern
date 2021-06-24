namespace LearningDesignPattern.DesignPattern.Structural.Composite.Example1
{
    // Client
    public class ProgramCompositeExample1
    {
        public void Companyhierarchy()
        {
            IEmployee pankaj = new Employee("pankaj", "IT");
            IEmployee sahil = new Employee("sahil", "IT");
            IEmployee sachin = new Employee("sachin", "HR");
            IEmployee ankit = new Employee("ankit", "HR");
            IEmployee monu = new Employee("monu", "HR");

            IEmployee shivani = new Manager("shivani", "IT")
                                        { SubOrdinates = { pankaj, sahil } };

            IEmployee vidika = new Manager("vidika", "HR")
                                { SubOrdinates = { sachin, ankit, monu } };

            IEmployee boss = new Manager("boss", "Head")
                                { SubOrdinates = { shivani, vidika } };

            boss.GetDetails(1);

        }
    }
}
