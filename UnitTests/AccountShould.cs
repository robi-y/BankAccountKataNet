using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace BankAccountKata.UnitTests
{
    public class AccountShould
    {
        private readonly ITransactionRepository _transactionRepository = Substitute.For<ITransactionRepository>();
        private readonly StatementPrinter statementPrinter = Substitute.For<StatementPrinter>();
        private readonly Account account;

        public AccountShould()
        {
            account = new Account(_transactionRepository, statementPrinter);
        }

        [Fact]
        public void LogDepositToTransactionRepository()
        {
            account.Deposit(100);

            _transactionRepository.Received().LogDeposit(100);
        }
      
        [Fact]
        public void LogWithdrawalToTransactionRepository()
        {
            account.Withdraw(100);

            _transactionRepository.Received().LogWithdrawal(100);
        }

        [Fact]
        public void UseStatementPrinterWithAllStatement_forPrintStatements()
        {
            var statements = new List<Statement> {new Statement()};
            _transactionRepository.AllStatements.Returns(statements);

            account.PrintStatement();

            statementPrinter.Received().Print(Arg.Any<List<Statement>>());
        }
    }
}
