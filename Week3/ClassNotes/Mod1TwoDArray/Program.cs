namespace Mod1TwoDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int[,] nums = new int[2, 2] { { 3, 4 }, { 4, 5 } };

            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] movieRatings;// new int[3, 4]; //[rows,cols]==>[users,movies]

            movieRatings = new int[2, 3];
            
            Console.WriteLine("Enter ratings for 3 users for 4 movies each (1-10)");
            for(int i=0;i<movieRatings.GetLength(0);i++)// number of rows, get len of first dimension
            {
                for(int j=0;j<movieRatings.GetLength(1);j++)//cols
                {

                    Console.Write($"User {i}, Movie{j}:");
                    movieRatings[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Movie Ratings:");

            for(int i=0;i<movieRatings.GetLength(0);i++)
            {
                for(int j=0;j<movieRatings.GetLength(1);j++)
                {
                    Console.Write($"{movieRatings[i, j]}" + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
