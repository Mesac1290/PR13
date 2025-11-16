using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task3
{
    internal class AudioBook : LibraryItem
    {
        public int Time { get; set; }
        public string Speaker {  get; set; }

        public AudioBook(int time, string speaker, string name, string author, string yearPublish, bool available) : base(name, author, yearPublish, available)
        {
            Time = time;
            Speaker = speaker;
        }
    }
}
