using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Account
    {
        private ITransactionRepository _transactionRepository;
        private StatementPrinter statementPrinter;

        public Account(ITransactionRepository _transactionRepository, StatementPrinter statementPrinter)
        {
            this._transactionRepository = _transactionRepository;
            this.statementPrinter = statementPrinter;
        }

        public void Deposit(int amount)
        {
            _transactionRepository.LogDeposit(amount);
        }

        public void Withdraw(int amount)
        {
            _transactionRepository.LogWithdrawal(amount);
        }

        public void PrintStatement()
        {
            var statements = _transactionRepository.AllStatements;
            statementPrinter.Print(statements);
        }

    }
}
