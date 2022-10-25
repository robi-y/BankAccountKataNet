using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace BankAccountKata.UnitTests
{
    public class StatementPrinterShould
    {
        private List<Statement> EMPTY_STATEMENT = new List<Statement>();

        [Fact]
        public void PrintHeaderForEmptyStatementList()
        {
            Console console = Substitute.For<Console>();
            var printer = new StatementPrinter(console);

            printer.Print(EMPTY_STATEMENT);

            console.Received().WriteLine("DATE       | AMOUNT  | BALANCE");
        }
    }
}
