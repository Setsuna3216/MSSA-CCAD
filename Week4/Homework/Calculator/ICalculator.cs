using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal interface ICalculator
    {
        public double Add(double x, double y);

        public double Subtract(double x, double y);

        public double Multiply(double x, double y);

        public double Divide(double x, double y);

    }

    
}
