using System;
using System.Collections.Generic;

namespace BankAccountKata
{
    public class InMemoryTransactionReopsitory : ITransactionRepository
    {
        public void LogDeposit(int amount)
        {
            throw new NotImplementedException();
        }

        public void LogWithdrawal(int amount)
        {
            throw new NotImplementedException();
        }

        public List<Statement> AllStatements
        {
            get { throw new NotImplementedException(); }
        }
    }
}