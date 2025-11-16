using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task2
{
    internal abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string Owner { get; set; }

        public BankAccount(string accountNumber, double balance, string owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
        }
    }
}
