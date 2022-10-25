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
        [Fact]
        public void LogDepositToTransactionRepository()
        {
            var transactionManager = Substitute.For<ITransactionManager>();
            var account = new Account();

            account.Deposit(100);

            transactionManager.Received().LogDeposit(100);
        }
    }

    public interface ITransactionManager
    {
        void LogDeposit(int amount);
    }
}
