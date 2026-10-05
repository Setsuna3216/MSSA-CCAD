using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2._2
{
    internal class Circle:Shape
    {
        //radius. override calculate area logic for circle

        public double r { get; set; }
        public override double CalculateArea()
        {
            return r * r * Math.PI;
        }
    }
}
