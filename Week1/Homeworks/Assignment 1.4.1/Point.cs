using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1._4._1
{
    internal struct Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public string PrintPoint()
        {
            return $"({x},{y})";
        }

    }
}
