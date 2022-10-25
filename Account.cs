using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Account
    {
        private ITransactionManager transactionManager;

        public Account(ITransactionManager transactionManager)
        {
            this.transactionManager = transactionManager;
        }

        public void Deposit(int amount)
        {
            transactionManager.LogDeposit(amount);
        }

        public void Withdraw(int amount)
        {
            throw new NotImplementedException();  
        }

        public void PrintStatement()
        {
            throw new NotImplementedException();    
        }

    }
}
