using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccountKata
{
    public class InMemoryTransactionReopsitory : ITransactionRepository
    {
        private List<Statement> statements = new List<Statement>();
        private Clock clock;

        public InMemoryTransactionReopsitory(Clock clock)
        {
            this.clock = clock;
        }

        public void LogDeposit(int amount)
        {
            var balance = calcBalance() + amount;
            statements.Add(new Statement
            {
                Amount = amount,
                Balance = balance,
                Date = clock.TodayAsString
            });
        }

        private int calcBalance()
        {
            return statements.Sum(st => st.Amount);
        }

        public void LogWithdrawal(int amount)
        {
            var balance = calcBalance() - amount;
            statements.Add(new Statement
            {
                Amount = -amount,
                Balance = balance,
                Date = clock.TodayAsString
            });
        }

        public List<Statement> AllStatements
        {
            get { return statements; }
        }
    }
}