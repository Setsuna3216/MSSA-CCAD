using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] flowerbed1 = { 1, 0, 0, 0, 1 };
            Console.WriteLine(CanFlowerBePlanted(flowerbed1, 1));  // Expected: True

            int[] flowerbed2 = { 1, 0, 0, 0, 1 };
            Console.WriteLine(CanFlowerBePlanted(flowerbed2, 2));  // Expected: False

            int[] flowerbed3 = { 0 };
            Console.WriteLine(CanFlowerBePlanted(flowerbed3, 1));  // Expected: True

            int[] flowerbed4 = { 1 };
            Console.WriteLine(CanFlowerBePlanted(flowerbed4, 1));  // Expected: False

            int[] flowerbed5 = { 0, 0, 0, 0 };
            Console.WriteLine(CanFlowerBePlanted(flowerbed5, 2));  // Expected: True

            int[] flowerbed6 = { 1, 0, 1 };
            Console.WriteLine(CanFlowerBePlanted(flowerbed6, 1));  // Expected: False

            int[] flowerbed7 = { 1, 0, 1 };
            Console.WriteLine(CanFlowerBePlanted(flowerbed7, 0));  // Expected: True
            //Q2
            Console.WriteLine(ClimbStairs(2));  // Expected: 2
            Console.WriteLine(ClimbStairs(3));  // Expected: 3
            Console.WriteLine(ClimbStairs(4));  // Expected: 5
            Console.WriteLine(ClimbStairs(5));  // Expected: 8
            Console.WriteLine(ClimbStairs(6));  // Expected: 13
        }

        static bool CanFlowerBePlanted(int[] flowerbed,int n)
        {
            int count = 0;
            if (n == 0)
            {
                return true;
            }
            if (flowerbed.Length == 1)
            {
                if (flowerbed[0] == 0)
                {
                    count++;
                    flowerbed[0] = 1;
                }
                if (count >= n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 0; i < flowerbed.Length; i++) 
            {
                if (i == 0)
                {
                    if (flowerbed[i] == 0 && flowerbed[i+1] == 0)
                    {
                        count++;
                        flowerbed[i] = 1;
                    }
                }
                else if (i == flowerbed.Length - 1)
                {
                    if (flowerbed[flowerbed.Length-1] == 0 && flowerbed[flowerbed.Length-2] == 0)
                    {
                        count++;
                        flowerbed[i] = 1;
                    }
                }
                else if (flowerbed[i] == 0 && i!=0 && i!= flowerbed.Length - 1)
                {
                    if(flowerbed[i-1] == 0 && flowerbed[i + 1] == 0)
                    {
                        count++;
                        flowerbed[i] = 1;
                    } 
                }
            }
            if (count >= n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int ClimbStairs(int n)
        {
            //n1 n2 n3 n4 n5 n6
            //1  2  3  5  8  13

            if (n == 1) 
            {
                return 1;
            }else if(n == 2) 
            {
                return 2;
            }else 
            {
                //n1+n2=n3
                //n2+n3=n4
                int num1 = 1;
                int num2 = 2;
                int num = 0;
                for (int i = 0; i < n-2; i++)
                {
                    num = num1 + num2;
                    num1= num2;
                    num2 = num;
                    
                }
                return num;
            }
            
        }
    }
}
