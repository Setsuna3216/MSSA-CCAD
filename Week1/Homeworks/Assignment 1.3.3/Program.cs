namespace Assignment_1._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array :");
            int numbersOfelements = int.Parse(Console.ReadLine());
            Console.WriteLine($"Input {numbersOfelements} number of elements in the array :");
            int[] elements = new int[numbersOfelements];

            for (int i = 0; i < numbersOfelements; i++)
            {
                Console.WriteLine($"element - {i}:");
                elements[i] = int.Parse(Console.ReadLine());
            }


            //Test
            Console.WriteLine("The values store into the array are:");
            foreach (int i in elements)
            {
                Console.Write($"{i} ");
            }

            Array.Reverse(elements);
            
            Console.WriteLine("\nThe values store into the array in reverse are:");
            foreach (int i in elements)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
