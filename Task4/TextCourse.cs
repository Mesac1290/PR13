using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PR13.Task4
{
    internal class TextCourse : Course
    {
        public int NumberOfChapters {  get; set; }
        public int VolumeText {  get; set; }
        public TextCourse(string title, string description, string author, double price, int numberOfChapters, int volumeText) : base(title, description, author, price)
        {
            NumberOfChapters = numberOfChapters;
            VolumeText = volumeText;
        }
    }
}
