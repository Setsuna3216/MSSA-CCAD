using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mod5Demo
{
    internal static class ExtensionMethodClass
    {
        public static bool CheckValue(this int i,int val)
        {
            return i> val;
        }
        public static bool ContainsDigits(this string s)
        {
            return Regex.IsMatch(s, @"\d");
        }
    }
}
