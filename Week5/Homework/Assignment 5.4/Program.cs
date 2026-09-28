namespace Assignment_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 - Display individual digits using recursion
            Console.WriteLine("Q1:");

            Console.Write("1234: ");
            DisplayIndividualDigits(1234);   // Expected: 1 2 3 4
            Console.WriteLine();

            Console.Write("56789: ");
            DisplayIndividualDigits(56789);  // Expected: 5 6 7 8 9
            Console.WriteLine();


            // Q2 - Sum of right diagonal
            Console.WriteLine("\nQ2:");

            int[,] matrix1 =
            {
                { 1, 2 },
                { 3, 4 }
            };

            Console.WriteLine(SumOfTheRightDiagonalsOfAMatrix(matrix1));
            // Expected: 5


            int[,] matrix2 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine(SumOfTheRightDiagonalsOfAMatrix(matrix2));
            // Expected: 15
        }

        static void DisplayIndividualDigits(int num)
        {
            if (num == 0)
            {
                return;
            }
            DisplayIndividualDigits(num/10);
            Console.Write(num % 10 + " ");
        }

        static int SumOfTheRightDiagonalsOfAMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i+j == matrix.GetLength(1) - 1)
                    {
                        sum = sum + matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
