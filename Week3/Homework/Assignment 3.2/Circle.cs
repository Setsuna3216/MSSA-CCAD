using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3._2
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public static double operator +(Circle circle1, Circle circle2)
        {
            return circle1.CalculateArea() + circle2.CalculateArea();
        }

        public static double operator -(Circle circle1, Circle circle2)
        {
            return circle1.CalculateArea() - circle2.CalculateArea();
        }
    }
}
