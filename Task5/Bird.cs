using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task5
{
    internal class Bird : Animal
    {
        public int Sweep { get; set; }
        public string TypeNesting {  get; set; }
        public Bird(string form, int age, string habitat, string diet,int sweep, string typeNesting) : base(form, age, habitat, diet)
        {
            Sweep = sweep;
            TypeNesting = typeNesting;
        }
    }
}
