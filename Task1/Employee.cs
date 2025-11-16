using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task1
{
    internal class Employee
    {
        public Employee(string name, string jobTitle, int salary, string dataReceived) 
        {
            Name = name;
            JobTitle = jobTitle;
            Salary = salary;
            DataReceived = dataReceived;
        }
        public string Name { set; get; }
        public string JobTitle { set; get; }
        public int Salary { get; set; }
        public string DataReceived{ get; set; }
    }

}
