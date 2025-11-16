using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task2
{
    internal class SavingAccount : BankAccount
    {
        public double Percent { get; set; }
        public SavingAccount(string accountNumber, double balance, string owner, double percent) :base(accountNumber, balance, owner)
        {
            Percent = percent;
        }
    }
}
