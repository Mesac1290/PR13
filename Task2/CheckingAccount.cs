using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task2
{
    internal class CheckingAccount: BankAccount
    {
        public double OverDraft { get; set; }
        public CheckingAccount(string accountNumber, double balance, string owner, double overDraft) : base(accountNumber, balance, owner)
        {
            OverDraft = overDraft;
        }
    }
}
