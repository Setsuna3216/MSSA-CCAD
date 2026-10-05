namespace Assignments_3._1
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Return even numbers, a method that returns a string of even numbers greater than 0 and less than 100.
            //If year is leap, Given a year as integer, write a method that checks if year is leap.
            //create a function to input a string and count number of spaces are in the string.
            /*function which takes an array as input and finds the first occurrence of 2 consecutive 1s 
             * and changes their value to 0.*/


            //Q1
            Console.WriteLine(ReturnEvenNumbers());
            //Q2
            Console.WriteLine(IfYearIsLeap(2016));
            Console.WriteLine(IfYearIsLeap(2018));
            //Q3
            CountNumberOfSpaces();
            //Q4
            ChangeConsecutive1sTo0([0, 2, 1, 1, 9, 1, 1]);



        }

        static string ReturnEvenNumbers()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0 & i != 0)
                {
                    result.Append($"{i} ");
                }

            }

            return result.ToString();

        }

        static bool IfYearIsLeap(int year)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void CountNumberOfSpaces()
        {
            Console.WriteLine("Please input a string : ");
            string input = Console.ReadLine();
            int spaceCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaceCount = spaceCount + 1;
                }
            }
            Console.WriteLine($"\"{input}\" contains {spaceCount} spaces");

        }

        static void ChangeConsecutive1sTo0(int[] numbers)
        {
            Console.Write($"Input: [");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    Console.Write($"{numbers[i]}");
                }
                else
                {
                    Console.Write($"{numbers[i]}, ");
                }
            }
            Console.WriteLine ("]");

            for (int i = 0; i < numbers.Length-1; i++) 
            { 

                if( numbers[i] == 1)
                {
                    if (numbers[i+1] == 1)
                    {
                        numbers[i] = 0;
                        numbers[i+1] = 0;
                        break;
                    }
                }
                
            }

            Console.Write($"Output: [");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    Console.Write($"{numbers[i]}");
                }
                else
                {
                    Console.Write($"{numbers[i]}, ");
                }
            }
            Console.WriteLine("]");
        }

    }
}
