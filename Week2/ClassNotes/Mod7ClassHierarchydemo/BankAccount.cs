using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7ClassHierarchydemo
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        protected decimal minimumBalance;
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if(value>=minimumBalance)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine($"Balance can't be less than {minimumBalance}");
                }
            }

        }
    }

    class CheckingAccount:BankAccount
    {
        public CheckingAccount()
        {
            base.minimumBalance = 100;
        }
    }

    class SavingsAccount:BankAccount
    {
        public SavingsAccount()
        {
            base.minimumBalance = 500;
        }
    }

}
