using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task3
{
    internal class Magazine : LibraryItem
    {
        public string Issue { get; set; }
        public string Periodicity { get; set; }

        public Magazine(string issue, string periodicity, string name, string author, string yearPublish, bool available) : base(name, author, yearPublish, available)
        {
            Issue = issue;
            Periodicity = periodicity;
        }
    }
}
