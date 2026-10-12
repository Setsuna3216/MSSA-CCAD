namespace Mod2Recursion2
{
    internal class Program
    {
        //PS(5)-->PS(4)-->PS(3)-->PS(2)-->PS(1)
        //1--4--9--16--25
        static void PrintSquares(int num)
        {
            if(num>1)
            {
                PrintSquares(num - 1);//Head Recursion
            }
            Console.WriteLine(num * num);
        }

        static void PrintSquares_Tail(int num)
        {
            Console.WriteLine(num * num);
            if (num > 1)
            {
                PrintSquares_Tail(num - 1);//Tail Recursion
            }
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Iteration..");
            int num = 5;
            for(int i=num;i>=1;i--)
            {
                Console.WriteLine(i * i);

            }
            Console.WriteLine("Head Recursion");
            PrintSquares(num);


            Console.WriteLine("Tail REcursion");
            PrintSquares_Tail(num);
        }
    }
}
