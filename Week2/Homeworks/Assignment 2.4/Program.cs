namespace Assignment_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Question 1
            Console.WriteLine("Q1:Find the sum of all array elements.");
            FindSum();
            // Question 2
            Console.WriteLine("Q2: Find the largest of three numbers.");
            FindLargestOf3Numbers();
            // Question 3
            Console.WriteLine("Q3: Find which quadrant the coordinate point lies.");
            FindQuadrant();

        }

        static void FindSum()
        {
            Console.WriteLine("Q1: Input the number of elements to be stored in the array :");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input {size} elements in the array: ");
            int sum = 0;
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"element - {i}:");
                numbers[i] = int.Parse(Console.ReadLine());
                sum = sum + numbers[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is : {sum} ");
        }

        static void FindLargestOf3Numbers()
        {

            int largestIndex = 0;
            int[] numbers = new int[3];

            Console.WriteLine($"Input the 1st number :");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input the 2nd number :");
            numbers[1] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input the 3rd number :");
            numbers[2] = int.Parse(Console.ReadLine());

            int largest = numbers[0];

            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                    largestIndex = i;
                }

            }

            if (largestIndex == 0)
            {
                Console.WriteLine("The 1st Number is the greatest among three");
            }
            else if (largestIndex == 1)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else if (largestIndex == 2)
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }
        }

        static void FindQuadrant()
        {
            int[] coordinate = new int[2];
            Console.WriteLine("Input the value for X coordinate :");
            coordinate[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate :");
            coordinate[1] = int.Parse(Console.ReadLine());

            if (coordinate[0] == 0)
            {
                if (coordinate[1] != 0)
                {
                    Console.WriteLine($"The coordinate point ({coordinate[0]},{coordinate[1]}) lies on the Y axis.");
                }
                else
                {
                    Console.WriteLine($"The coordinate point ({coordinate[0]},{coordinate[1]}) lies on the origin.");
                }
            }
            else if (coordinate[0] < 0)
            {
                if (coordinate[1] > 0)
                {
                    Console.WriteLine($"The coordinate point ({coordinate[0]},{coordinate[1]}) lies in the Second quadrant");
                }
                else if (coordinate[1] < 0)
                {
                    Console.WriteLine($"The coordinate point ({coordinate[0]},{coordinate[1]}) lies in the Thrid quadrant");
                }
                else
                {
                    Console.WriteLine($"The coordinate point ({coordinate[0]},{coordinate[1]}) lies on the X axis.");
                }
            }
            else if (coordinate[0] > 0)
            {
                if (coordinate[1] > 0)
                {
                    Console.WriteLine($"The coordinate point ({coordinate[0]},{coordinate[1]}) lies in the First quadrant");
                }
                else if (coordinate[1] < 0)
                {
                    Console.WriteLine($"The coordinate point ({coordinate[0]},{coordinate[1]}) lies in the Fourth quadrant");
                }
                else
                {
                    Console.WriteLine($"The coordinate point ({coordinate[0]},{coordinate[1]}) lies on the X axis.");
                }
            }

        }


    }
}
