using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningDesignPattern.DesignPattern.Behavioral.Command.Example1
{
    // client
    public class ProgramCommandExample1
    {
        public void UndoInTransactionOfBankCommand()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand> {
                            new BankAccountCommand(ba,BankAccountCommand.Action.Deposit,100),
                            new BankAccountCommand(ba,BankAccountCommand.Action.Withdraw,1000)
                           };
            Console.WriteLine(ba);
            foreach (var c in commands)
                c.Call();

            Console.WriteLine(ba);
            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            Console.WriteLine(ba); ;
        }
    }
}
