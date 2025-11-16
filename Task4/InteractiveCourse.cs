using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PR13.Task4
{
    internal class InteractiveCourse: Course
    {
        public int NumberOfExercises { get; set; }
        public int VerificationSystem {  get; set; }

        public InteractiveCourse(string title, string description, string author, double price, int numberOfExercises, int verificationSystem) : base(title, description, author, price)
        {
            NumberOfExercises = numberOfExercises;
            VerificationSystem = verificationSystem;
        }

    }
}
