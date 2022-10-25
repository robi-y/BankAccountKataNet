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
        private List<Statement> FULL_STATEMENT = new List<Statement>
        {
            new Statement {Amount = 1000, Balance = 1000, Date = "01/11/2015"},
            new Statement {Amount = -100, Balance = 900, Date = "02/11/2015"},
        };

        private Console console = Substitute.For<Console>();
        private StatementPrinter printer;

        public StatementPrinterShould()
        {
            printer = new StatementPrinter(console);
        }

        [Fact]
        public void PrintHeaderForEmptyStatementList()
        {
            printer.Print(EMPTY_STATEMENT);

            console.Received().WriteLine("DATE       | AMOUNT  | BALANCE");
        }

        [Fact]
        public void PrintFullStatement()
        {
            printer.Print(FULL_STATEMENT);

            Received.InOrder(() =>
            {
                console.WriteLine("DATE       | AMOUNT  | BALANCE");
                console.WriteLine("02/11/2015 | -100.00 | 900.00");
                console.WriteLine("01/11/2015 | 1000.00 | 1000.00");
            });
        }

    }
}
