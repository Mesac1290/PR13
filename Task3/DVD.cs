using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task3
{
    internal class DVD : LibraryItem
    {
        public int Time { get; set; }
        public int Rating { get; set; }

        public DVD(int time, int rating, string name, string author, string yearPublish, bool available) : base(name, author, yearPublish, available)
        {
            Time = time;
            Rating = rating;
        }
    }
}
