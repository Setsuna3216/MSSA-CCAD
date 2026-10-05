using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2._2
{
    internal abstract class Shape
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string color { get; set; }

        public abstract double CalculateArea();

    }
}
