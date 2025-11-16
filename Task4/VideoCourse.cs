using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task4
{
    internal class VideoCourse : Course
    {
        public int NumberOfVideos {  get; set; }
        public int GeneralTime {  get; set; }

        public VideoCourse(string title, string description, string author, double price, int numberOfVideos, int generalTime) : base(title, description, author, price)
        {
            NumberOfVideos = numberOfVideos;
            GeneralTime = generalTime;
        }
    }
}
