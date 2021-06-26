﻿namespace LearningDesignPattern.DesignPattern.Behavioral.Command.Example1
{
    // Concrete command
    public class BankAccountCommand : ICommand
    {
        private BankAccount account;
        private Action action;
        private int amount;
        private bool succeeded;
        public BankAccountCommand(BankAccount account,Action action,int amount)
        {
            this.account = account;
            this.action = action;
            this.amount = amount;
        }

        public void Call()
        {
            switch (action)
            {
                case Action.Deposit:
                    account.Deposit(amount);
                    succeeded = true;
                    break;
                case Action.Withdraw:
                    succeeded = account.Withdraw(amount);
                    break;
                default:
                    break;
            }
        }

        public void Undo()
        {
            if (!succeeded) 
                return;

            switch (action)
            {
                case Action.Deposit:
                    account.Withdraw(amount);
                    break;
                case Action.Withdraw:
                    account.Deposit(amount);
                    break;
                default:
                    break;
            }
        }

        public enum Action
        {
            Deposit, Withdraw
        }
    }
}
