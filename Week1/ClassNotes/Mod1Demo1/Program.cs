
//Namespace: logical group of related classes/ types
//standard namespaces are present which belong to FCL 

/*
 * 
 * 
 */
//using System;
//using System.Collections;
namespace Test
{
    internal class Program
    {
        //entry point
        static void Main(string[] args)
        {//c# is a highly type safe
           
            //console :class
            //writeline: method in class
            Console.WriteLine("Hello, World!");
            Console.ForegroundColor = ConsoleColor.Green;//set
            Console.WriteLine(Console.ForegroundColor.ToString());//get
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Beep();
            Console.WriteLine("Welcome to CCAD23!");
        }
     
    }
}

namespace Test1
{

}
