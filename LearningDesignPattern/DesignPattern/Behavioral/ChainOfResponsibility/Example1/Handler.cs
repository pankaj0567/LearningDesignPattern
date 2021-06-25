namespace LearningDesignPattern.DesignPattern.Behavioral.ChainOfResponsibility.Example1
{
    public abstract class Handler
    {
        public Handler rsHandler;
        public Handler(Handler handler)
        {
            rsHandler = handler;
        }

        public abstract void dispatchRs(long requestedAmount);
    }
}
