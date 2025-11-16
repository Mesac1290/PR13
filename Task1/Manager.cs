using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13
{
    internal class Manager: Employee
    {
        public int TeameSize { get; set; }
        public void Meeting ()
        {
            Console.WriteLine("Проведено собрание");
        }
    }
}
