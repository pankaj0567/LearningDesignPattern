namespace LearningDesignPattern.DesignPattern.Behavioral.Command.Example1
{
    // Command
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
