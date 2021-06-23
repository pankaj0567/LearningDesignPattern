namespace LearningDesignPattern.DesignPattern.Creational.Builder.Example2
{
    public class PersonJobBuilder : PersonInfoBuilder
    {
        public PersonJobBuilder WorkAsA(string position)
        {
            person.Position = position;
            return this;
        }
    }
}
