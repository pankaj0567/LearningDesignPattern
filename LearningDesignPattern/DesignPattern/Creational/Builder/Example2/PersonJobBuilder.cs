namespace LearningDesignPattern.DesignPattern.Creational.Builder.Example2
{
    public class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>>
                                           where TSelf: PersonJobBuilder<TSelf>
    {
        public TSelf WorkAsA(string position)
        {
            person.Position = position;
            return (TSelf)this;
        }
    }
}
