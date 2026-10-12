using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Generics
{
    //Generic template class which can be used for different valid data types
    // T can replaced by any letter, T is used for standard convention
    internal class Swap<T>
    {
        public void SwapData(ref T num1,ref T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
    class CustomList<T>
    {
        T[] data = new T[100]; 
    }


}
