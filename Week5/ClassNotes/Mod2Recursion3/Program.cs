namespace Mod2Recursion3
{
    internal class Program
    {
        //return the sum of all the numbers in the series till 1
        //5 : 5+4+3+2+1:15
        //6:6+5+4+3+2+1
        // 6:sum(5)+6
        //sum(6):sum(5)+6
        //sum(100)=sum(99)+100
        //sum(n)=sum(n-1)+n
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum by iteration :{Sum_Iteration(10)}");
            Console.WriteLine($"Sum by recursion :{Sum_Recursion(4)}");
        }

        //4
        //3
        //2
        //1
        static int Sum_Recursion(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Sum_Recursion(n - 1) + n;
        }

        static int Sum_Iteration(int num)
        {
            int sum = 0;
            int i = 1;
            while(i<=num)
            {
                sum += i;
                i++;
            }
            return sum;
        }
    }
}
