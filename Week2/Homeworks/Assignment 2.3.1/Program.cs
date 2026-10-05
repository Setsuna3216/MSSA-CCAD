namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the details from same file and print on console.
            
            const string path = @"C:\MSSA\CCAD10975\Demo\Assignment 2.3.1\";
            Console.WriteLine("Enter a file name to create :");
            string filename = path + Console.ReadLine() + ".txt";
            StreamWriter writer = null;
            
            writer = File.CreateText(filename);
            writer.WriteLine("New file is created at " + DateTime.Now);
            writer.WriteLine("name: w");
            writer.WriteLine("age: 25");
            writer.WriteLine("address: 1234 st");
            writer.Close();
            Console.WriteLine("File created successfully!");

                

            Console.WriteLine("Reading file content:");

            using (StreamReader sr = new StreamReader(filename))
            {
                Console.WriteLine(sr.ReadToEnd());

            }

        }
    }
}
