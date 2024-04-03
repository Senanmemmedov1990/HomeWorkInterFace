using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPolymorphism__Abstraction__Abstract__Interface
{
    internal class Triangle : Shape
    {
        public double Height;
        public double Width;
        public override double CalculateArea()
        {
            return Height * Width / 2;
        }
    }
}
