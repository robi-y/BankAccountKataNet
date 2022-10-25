using System.Collections.Generic;

namespace BankAccountKata
{
    public class StatementPrinter
    {
        private Console console;
        public StatementPrinter(Console console)
        {
            this.console = console;
        }

        public virtual void Print(List<Statement> statements)
        {
            console.WriteLine("DATE       | AMOUNT  | BALANCE");
        }
    }
}