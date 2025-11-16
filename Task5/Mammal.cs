using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task5
{
    internal class Mammal : Animal
    {
        public string Fur {  get; set; }
        public int LengthOfPregnancy { get; set; }

        public Mammal(string form, int age, string habitat, string diet, string fur, int lengthOfPregnancy): base(form, age, habitat,diet)
        {
            Fur = fur;
            LengthOfPregnancy = lengthOfPregnancy;
        }
    }
}
