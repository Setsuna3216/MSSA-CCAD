using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphismdemo
{
    // celcius -->fahrenheit
    // miles-->kms
    // static classes cannot be instantiated. the object needed will be provided by compiler and is
    //shared among all the code
    //utility classes , helper
    internal static class Conversions
    {
        private static int i;
        public static double CelciusToFahrenheit(double temp)
        {
            return (temp * (9.0 / 5.0)) + 32.0;
        }
    }
    // static classes cannot be inherited
    //class A:Conversions
    //{

    //}

}
