namespace Mod3Forloopdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loops used for performing repeated tasks for a definite amount of time
            // used for iterating over a collection/ array
            //for(initialization;condition;increment/decrement)

            Console.WriteLine("Numbers from 1 till 10");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            
            int j = 1;//initialize
            while(j<=10)//condition
            {
                Console.WriteLine(j);
                j++;//increment
            }
            Console.WriteLine("reversed numbers");
            for(int i=10;i>=1;i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("even numbers from 1 till 50");
            for(int i=1;i<=50;i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            for(int i=2;i<=50;i=i+2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
