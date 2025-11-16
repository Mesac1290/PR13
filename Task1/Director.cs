using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task1
{
    internal class Director : Employee
    {
        public Director(string name, string jobTitle, int salary, string dataReceived, string department) : base(name, jobTitle, salary,dataReceived)
        {
            Department = department;
        }
        private int budget;
        public string Department { get; set; }
        public void Budget(int budget)
        {
            Console.WriteLine("Утверждает бюджет");
            this.budget = budget;
        }
    }
}
