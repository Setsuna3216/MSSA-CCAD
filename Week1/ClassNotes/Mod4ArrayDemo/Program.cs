namespace Mod4ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;// a i allocated on stack with value 10
            int b = a;// b is allocated on stack and holds 10
            //value type: these are the primitiv data types which are allocated memory on stack and they
            //contain actual value(data) 

            //reference types:these are allocated on heap. the variable is on stack but it holds the 
            //reference / address where the data is allocated
            // string , array, class objects

            string s1 = "hello";// s1 is a ref type holding address of the mem area from heap
            string s2 = s1;// s2 also points to the same memory area

            //Array is a reference type, consisting of similar data type elements
            int[] numbers;//declaration
           
            numbers = new int[5];// 0,1,2,3,4
            numbers[0] = 45;
            numbers[1] = 56;
            numbers[2] = 58;
            numbers[3] = 34;
            numbers[4] = 90;
          //  numbers[5] = 56;
           for(int i = 0; i < numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);// reading
            }
            float[] temperatures;
            Console.WriteLine("How many readings are expected today?");
            int readings = Int32.Parse(Console.ReadLine());
            temperatures = new float[readings];
            Console.WriteLine($"Enter {readings} temperatures.. ");

            for(int i=0;i<temperatures.Length;i++)
            {
                Console.WriteLine($"Enter temperature {i +1}");
                temperatures[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Entered temperatures are..");
            //LINQ
            foreach(var temp in temperatures)
            {
                Console.WriteLine(temp);
            }

            int[] scores = { 1, 2, 34, 56 };

            string[] names = { "Zoe", "Alex", "Frank" };
            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine(names[i]);
            }
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

            //Object o = new Object();

            Array.Sort(temperatures);//ascending
            Array.Reverse(temperatures);
            

            Console.WriteLine("Sorted temperatures..");
            foreach (var temp in temperatures)
            {
                Console.WriteLine(temp);
            }

            string[] hobbies;
            Console.WriteLine("Enter number of hobbies you want to enter..");
            var numberHobbies = Int32.Parse(Console.ReadLine());
            hobbies = new string[numberHobbies];

            Console.WriteLine($"Enter {numberHobbies} hobbies..");
            for(int i=0;i<numberHobbies;i++)
            {
                Console.WriteLine($"Hobby[{i + 1}]:");
                hobbies[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Entered hobbies are:");
            foreach(var hobby in hobbies)
            {
                Console.WriteLine(hobby);
            }

            List<string> cities = new List<string>();
            cities.Add("NY");


        }
    }
}
