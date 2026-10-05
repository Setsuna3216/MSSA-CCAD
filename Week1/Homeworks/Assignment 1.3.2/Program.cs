namespace Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 1.3.2");
            // 1. Different ways array is declared
            int[] numbers;
            string[] name1;
            double[] price;
            // 2. Different ways array is initialized
            numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            string[] name2 = {"a", "b", "c"};



            //3. Properties of Array
            Console.WriteLine(numbers.Length);

            //4. Methods of Array class
        

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
