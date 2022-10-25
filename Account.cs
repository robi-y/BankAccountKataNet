using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Account
    {
        private ITransactionRepository transactionRepository;
        private StatementPrinter statementPrinter;

        public Account(ITransactionRepository transactionRepository, StatementPrinter statementPrinter)
        {
            this.transactionRepository = transactionRepository;
            this.statementPrinter = statementPrinter;
        }

        public void Deposit(int amount)
        {
            transactionRepository.LogDeposit(amount);
        }

        public void Withdraw(int amount)
        {
            transactionRepository.LogWithdrawal(amount);
        }

        public void PrintStatement()
        {
            var statements = transactionRepository.AllStatements;
            statementPrinter.Print(statements);
        }

    }
}
