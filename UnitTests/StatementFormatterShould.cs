using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankAccountKata.UnitTests
{
    public class StatementFormatterShould
    {
        [Fact]
        public void ReturnFormattedString()
        {
            var statement = new Statement {Amount = -100, Balance = 900, Date = "02/11/2015"};
            var formatter = new StatementPrinter.StatementFormatter();

            var formatted = formatter.Format(statement);

            Assert.Equal("02/11/2015 | -100.00 | 900.00", formatted);

        }
    }
}
