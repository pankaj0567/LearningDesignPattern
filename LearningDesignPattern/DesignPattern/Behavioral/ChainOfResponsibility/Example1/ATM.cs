namespace LearningDesignPattern.DesignPattern.Behavioral.ChainOfResponsibility.Example1
{
    public class ATM
    {
        private readonly TwoThousandHandler twoThousandHandler;
        private readonly FiveHundredHandler fiveHundredHandler;
        private readonly TwoHundredHandler twoHundredHandler;
        private readonly HundredHandler hundredHandler;

        public ATM()
        {
            hundredHandler = new HundredHandler(null);
            twoHundredHandler = new TwoHundredHandler(hundredHandler);
            fiveHundredHandler = new FiveHundredHandler(twoHundredHandler);
            twoThousandHandler = new TwoThousandHandler(fiveHundredHandler);
        }

        public void withdraw(long requestedAmount)
        {
            twoThousandHandler.dispatchRs(requestedAmount);
        }
    }
}
