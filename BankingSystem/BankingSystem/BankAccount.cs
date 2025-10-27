using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        { 
            this.Balance = balance;
        }
        public decimal Balance 
        {
            get 
            return balance;
            }
    }
}
