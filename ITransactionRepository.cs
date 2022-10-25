using System.Collections.Generic;

namespace BankAccountKata
{
    public interface ITransactionRepository
    {
        void LogDeposit(int amount);
        void LogWithdrawal(int amount);
        List<Statement> AllStatements { get; }
    }
}