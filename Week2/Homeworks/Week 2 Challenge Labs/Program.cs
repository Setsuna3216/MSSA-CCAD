namespace Week_2_Challenge_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 read temperature in Fahrenheit 

            Console.WriteLine("Q1---------------");
            Console.WriteLine("Enter Temperature in Fahrenheit:");

            double temp = double.Parse(Console.ReadLine());

            if (temp > 80)
            {
                Console.WriteLine("Temperature out of range");
            }
            else if (temp >= 66)
            {
                Console.WriteLine("Its Very Hot");
            }
            else if (temp >= 51)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temp >= 36)
            {
                Console.WriteLine("Normal in Weather");
            }
            else if(temp >= 21)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp >= 11)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp >= 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else
            {
                Console.WriteLine("Temperature out of range");
            }

            //2. takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
            Console.WriteLine("Q2---------------");
            string correctUserId = "admin";
            string correctPassword = "1234";

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Enter User ID:");
                string enteredUserId = Console.ReadLine();

                Console.WriteLine("Enter Password:");
                string enteredPassword = Console.ReadLine();

                if (enteredUserId == correctUserId && enteredPassword == correctPassword)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong User ID or Password.");
                    Console.WriteLine($"You have {2 - i} attempts left.");
                }

                if (i == 2)
                {
                    Console.WriteLine("User rejected.");
                }
            
            }

            //3.a number and a width also a number, as input and then displays a triangle of that width, using that number.
            Console.WriteLine("Q3---------------");
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the desired width: ");
            int width = int.Parse(Console.ReadLine());

            int rep = width;
            for (int i = 0; i < width; i++)
            {
                for (int j  = 0; j < rep; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
                rep = rep - 1;
            }
            //4.
            Console.WriteLine("Q4---------------");
            string division;
            
            Console.WriteLine("Input the Roll Number of the student :");
            int rollNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Name of the Student :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Physics mark:");
            int physics = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemistry mark:");
            int chemistry = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Computer Application mark:");
            int computer = int.Parse(Console.ReadLine());
            int total = physics + chemistry + computer;
            double percentage = total / 3.0;
            if (percentage >= 80)
            {
                division = "First";
            }
            else if (percentage >= 65)
            {
                division = "Second";
            }
            else if (percentage >= 50)
            {
                division = "Third";
            }
            else
            {
                division = "Fourth";
            }

            Console.WriteLine($"Roll No :{rollNumber}");
            Console.WriteLine($"Name of Student :{name}");
            Console.WriteLine($"Marks in Physics : {physics}");
            Console.WriteLine($"Marks in Chemistry : {chemistry}");
            Console.WriteLine($"Marks in Computer Application :{computer}");
            Console.WriteLine($"Total Marks ={total}");
            Console.WriteLine($"Percentage ={percentage:F2}");
            Console.WriteLine($"Division = {division}");

        }
    }
}
