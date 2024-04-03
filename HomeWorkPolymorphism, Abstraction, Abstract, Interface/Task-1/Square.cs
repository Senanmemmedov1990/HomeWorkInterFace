using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal class Square : Shape
    {
        public double Kvadrat { get; set; }
        public override double CalculateArea()
        {
            return Kvadrat * Kvadrat;
        }
    }
}
