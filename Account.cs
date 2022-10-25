using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Account
    {
        private ITransactionManager transactionManager;
        private StatementPrinter statementPrinter;

        public Account(ITransactionManager transactionManager, StatementPrinter statementPrinter)
        {
            this.transactionManager = transactionManager;
            this.statementPrinter = statementPrinter;
        }

        public void Deposit(int amount)
        {
            transactionManager.LogDeposit(amount);
        }

        public void Withdraw(int amount)
        {
            transactionManager.LogWithdrawal(amount);
        }

        public void PrintStatement()
        {
            var statements = transactionManager.AllStatements;
            statementPrinter.Print(statements);
        }

    }
}
