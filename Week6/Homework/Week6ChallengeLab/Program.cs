namespace Week6ChallengeLab
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] matrix1 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int[,] matrix2 =
            {
                { 5,  1,  9, 11 },
                { 2,  4,  8, 10 },
                { 13, 3,  6,  7 },
                { 15, 14, 12, 16 }
            };

            Clockwise90RotationMatrix(matrix1);
            Clockwise90RotationMatrix(matrix2);


        }

        static void Clockwise90RotationMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = row + 1; column < matrix.GetLength(0); column++)
                {
                    int temp = matrix[row, column];
                    matrix[row, column] = matrix[column, row];
                    matrix[column, row] = temp;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(0) / 2; column++)
                {
                    int temp = matrix[row, column];

                    matrix[row, column] = matrix[row, matrix.GetLength(0) - 1 - column];

                    matrix[row, matrix.GetLength(0) - 1 - column] = temp;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(0); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
