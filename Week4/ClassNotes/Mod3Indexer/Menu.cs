using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Indexer
{
    internal class Menu
    {
        private string[] fooditems;
        private string[] beverages;
        public Menu(int size,int size2)
        {
            fooditems = new string[size];
            beverages = new string[size2];
        }
        //helper
        public int Count
        {
            get { return fooditems.Length; }
        }


        public int this[int index,int i]
        {
            get
            {
                return index;
            }
        }
        //indexer

        public string this[int index]
        {
            get
            {
                if(index<fooditems.Length && !(index<0))
                return fooditems[index];
               
                return "No data";
            }
            set
            {
                if (index < fooditems.Length && !(index < 0))
                {

                    fooditems[index] = value;
                }
                else
                {
                    Console.WriteLine("Index not witihin range");
                }
            }
        }
    }
}
