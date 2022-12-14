using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace BankAccountKata.BehaviorTests
{
    public class PrintStatementFeature
    {
        private Console console = Substitute.For<Console>();
        private Clock clock = Substitute.For<Clock>();
        private ITransactionRepository transactionRepository;
        private StatementPrinter statementPrinter;

        public PrintStatementFeature()
        {
            clock.TodayAsString.Returns("01/11/2015", "02/11/2015", "10/11/2015");
            transactionRepository = new InMemoryTransactionReopsitory(clock);
            statementPrinter = new StatementPrinter(console);
        }

        [Fact]
        public void PrintAllClientStatements()
        {
            var account = new Account(transactionRepository, statementPrinter);

            account.Deposit(1000);
            account.Withdraw(100);
            account.Deposit(500);

            account.PrintStatement();

            Received.InOrder(() =>
            {
                console.Received().WriteLine("DATE       | AMOUNT  | BALANCE");
                console.Received().WriteLine("10/11/2015 | 500.00 | 1400.00");
                console.Received().WriteLine("02/11/2015 | -100.00 | 900.00");
                console.Received().WriteLine("01/11/2015 | 1000.00 | 1000.00");
            });        
        }
    }
}
