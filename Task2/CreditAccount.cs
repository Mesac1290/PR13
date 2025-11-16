using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task2
{
    internal class CreditAccount: BankAccount
    {
        public double Limit { get; set; }
        public int MaturityPeriod { get; set; }
        public CreditAccount(string accountNumber, double balance, string owner, double limit, int maturityPeriod) : base(accountNumber, balance, owner)
        {
            Limit = limit;
            MaturityPeriod = maturityPeriod;
        }
    }
}
