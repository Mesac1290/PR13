using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task1
{
    internal class Manager: Employee
    {
        public Manager(string name, string jobTitle, int salary, string dataReceived, int teamSize) : base(name, jobTitle, salary, dataReceived)
        {
            TeamSize = teamSize;
        }
        public int TeamSize { get; set; }
        public void Meeting ()
        {
            Console.WriteLine("Проведено собрание");
        }
    }
}
