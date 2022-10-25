using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace BankAccountKata.UnitTests
{
    public class TransactionRepositoryShould
    {
        private const string SOMEDAY = "01/11/2015";

        [Fact]
        public void ForDeposit_LogStsatementInMemoty()
        {
            var clock = Substitute.For<Clock>();
            clock.TodatAsString.Returns(SOMEDAY);

            var tranactions = new InMemoryTransactionReopsitory(clock);

            tranactions.LogDeposit(1000);

            Assert.Equal(1, tranactions.AllStatements.Count);

            Assert.Equal(createStatement(SOMEDAY, 1000, 1000), tranactions.AllStatements[0]);
        }

        private Statement createStatement(string date, int amount, int balance)
        {
            return new Statement { Date = date, Amount = amount, Balance = balance };
        }
    }
}
