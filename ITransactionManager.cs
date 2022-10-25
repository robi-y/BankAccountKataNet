using System.Collections.Generic;

namespace BankAccountKata
{
    public interface ITransactionManager
    {
        void LogDeposit(int amount);
        void LogWithdrawal(int amount);
        List<Statement> AllStatements { get; }
    }

    public class Statement
    {
    }
}