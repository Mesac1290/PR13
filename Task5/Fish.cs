using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task5
{
    internal class Fish : Animal
    {
        public string Scales { get; set; }
        public int DepthOfHabitat {  get; set; }
        public Fish(string form, int age, string habitat, string diet, string scales, int depthOfHabital) : base(form, age, habitat, diet)
        {
            Scales = scales;
            DepthOfHabitat = depthOfHabital;
        }
    }
}
