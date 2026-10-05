using System.Drawing;

namespace Assignment_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 2D array
            Create2DArray();
            //Q2 addition of two Matrices of same size
            AddOf2Matrices();
            //Q3 overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.
            Circle circle1 = new Circle(5);
            //circle1.CalculateArea();
            Circle circle2 = new Circle(6);
            //circle2.CalculateArea();

            Console.WriteLine($"Area adding: {circle1 + circle2}");
            Console.WriteLine($"Area difference: {circle1 - circle2}");

            //Q4 takes 4 numbers as input to calculate the total and average.
            int[] numbers = Input4Numbers();
            Calculate4Numbers(out int total, out double average, numbers);
            Console.Write("The average of ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.Write(", ");
                }
                    
            }
            Console.WriteLine($" is {average} ");
            Console.WriteLine($"The total is {total} ");

            //Q5 finds the index of a given item in the array
            Console.WriteLine(Search([1, 5, 3], 5));
            Console.WriteLine(Search([9, 8, 3], 3));
            Console.WriteLine(Search([1, 2, 3], 4));
        }

        static void Create2DArray()
        {
            int[,] numbers = new int[2,3];
            numbers[0, 0] = 2;
            numbers[0, 1] = 3;
            numbers[0, 2] = 4;
            numbers[1, 0] = 1;
            numbers[1, 1] = 4;
            numbers[1, 2] = 6;

            for (int i = 0; i < numbers.GetLength(0); i++) 
            {
                Console.Write(" | ");
                for (int j = 0; j < numbers.GetLength(1); j++) 
                {
                    Console.Write(numbers[i,j]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        static void AddOf2Matrices()
        {
            Console.WriteLine("Input the size of the square matrix (less than 5):");
            int size = int.Parse(Console.ReadLine());
            int[,] matrice1 = new int[size, size];
            int[,] matrice2 = new int[size, size];
            int[,] matrice3 = new int[size, size];

            Console.WriteLine("Input elements in the first matrix :");
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"element - : [{i}],[{j}]:  ");
                    matrice1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Input elements in the second matrix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"element - : [{i}],[{j}]:  ");
                    matrice2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The First matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrice1[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Second matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrice2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The Addition of two matrix is :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrice3[i, j] = matrice2[i, j] + matrice1[i, j];
                    Console.Write(matrice3[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        static int[] Input4Numbers()
        {

            int[] numbers = new int[4];
            Console.WriteLine("Enter the First number: ");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            numbers[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third number: ");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Fourth number: ");
            numbers[3] = int.Parse(Console.ReadLine());

            return numbers;
        }

        static void Calculate4Numbers(out int total, out double average, params int[] numbers)
        {
            total = 0;
            average = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            average = (double)total / numbers.Length;
        }


        static int Search(int[]numbers, int target) 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    return i;
                }
                
            }
            
            return -1;
        }

    }
}
