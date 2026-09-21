namespace Week4ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 If number contains 3
            //Q2 Divisible by 2 or 3
            //Q3 Write a function that reverses a string. The input string is given as an array of characters s.
        }

        static bool IfNumberContains3(int num)
        {
            int number = num;
            while (number != 0) 
            {
                int remainder = number % 10;
                if (remainder == 3)
                {
                    return true;
                }
                else
                {
                    number = (number - remainder) /10; 
                }
            
            }
            return false;
        }

        static int DivisibleBy2Or3(int num1, int num2)
        {
            if ((num1 % 2 == 0 || num1 % 3 == 0)&& (num2 % 2 == 0 || num2 % 3 == 0))
            { 
                return num1 * num2;
                
            }else
            {
                return num1 + num2;
            }
        }

        static void ReverseString(char[] s)
        {
            for(int i =0; i < s.Length/2; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
    }
}
