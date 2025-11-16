using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task4
{
    internal class Course
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Course(string title, string description, string author, double price) 
        {
            Title = title;
            Description = description;
            Author = author;
            Price = price;
        }
    }
}
