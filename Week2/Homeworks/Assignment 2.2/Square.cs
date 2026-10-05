using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2._2
{
    internal class Square:Shape
    {
        // change the calculate area logic. Add property like side of square

        public double l { get; set; }
        public override double CalculateArea()
        {
            return l * l;
        }

    }
}
