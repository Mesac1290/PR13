using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task3
{
    internal class Book : LibraryItem
    {
        public int Size { get; set; }
        public string ISBN { get; set; }

        public Book(int size, string iSBN, string name, string author, string yearPublish, bool available): base(name, author, yearPublish, available)
        {
            Size = size;
            ISBN = iSBN;
        }
    }
}
