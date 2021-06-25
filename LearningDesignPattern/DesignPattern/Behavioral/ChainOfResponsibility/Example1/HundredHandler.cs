using System;

namespace LearningDesignPattern.DesignPattern.Behavioral.ChainOfResponsibility.Example1
{
    public class HundredHandler : Handler
    {
        public HundredHandler(Handler handler): base (handler)
        {

        }

        public override void dispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount % 100;

            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.dispatchRs(pendingAmountToBeProcessed);
            }
        }
    }
}
