using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR13.Task5
{
    internal class Animal
    {
        public string Form {  get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet {  get; set; }
        public Animal(string form, int age, string habitat, string diet) 
        { 
            Form = form;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }
    }
}
