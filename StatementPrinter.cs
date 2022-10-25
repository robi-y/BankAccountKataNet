using System.Collections.Generic;
using System.Linq;

namespace BankAccountKata
{
    public class StatementPrinter
    {
        private Console console;

        public StatementPrinter()
        {
        }

        public StatementPrinter(Console console)
        {
            this.console = console;
        }

        public virtual void Print(List<Statement> statements)
        {
            PrintHeader();

            PrintStatements(statements);
        }

        private void PrintStatements(List<Statement> statements)
        {
            var statementFormatter = new StatementFormatter();
            var reversedStatements = statements.AsEnumerable().Reverse().ToList();

            reversedStatements.ForEach(
                statement => console.WriteLine(statementFormatter.Format(statement)));
        }

        private void PrintHeader()
        {
            console.WriteLine("DATE       | AMOUNT  | BALANCE");
        }

        public class StatementFormatter
        {
            public string Format(Statement statement)
            {
                return string.Format("{0} | {1:0.00} | {2:0.00}",
                    statement.Date,
                    statement.Amount,
                    statement.Balance);
            }
        }
    }
}