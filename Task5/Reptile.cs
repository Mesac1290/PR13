using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task5
{
    internal class Reptile : Animal
    {
        public string TypeLeather { get; set; }
        public int Temperature {  get; set; }
        public Reptile(string form, int age, string habitat, string diet, string typeLeather, int temperature) : base(form, age, habitat, diet)
        {
            TypeLeather = typeLeather;
            Temperature = temperature;
        }
    }
}
