using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task3
{
    internal abstract class LibraryItem
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string YearPublish { get; set; }
        public bool Available { get; set; }

        public LibraryItem(string name, string author, string yearPublish,bool available)
        {
            Name = name;
            Author = author;
            YearPublish = yearPublish;
            Available = available;
        }
    }
}
