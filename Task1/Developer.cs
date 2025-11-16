using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13
{
    internal class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public void PrintCode()
        {
            Console.WriteLine("Печатает код");

        }
    }
}
