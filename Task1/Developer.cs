using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task1
{
    internal class Developer : Employee
    {
        public Developer(string name, string jobTitle, int salary, string dataReceived, string programmingLanguage) : base(name, jobTitle, salary, dataReceived)
        {
            ProgrammingLanguage = programmingLanguage;
        }
        public string ProgrammingLanguage { get; set; }
        public void PrintCode()
        {
            Console.WriteLine("Печатает код");

        }
    }
}
