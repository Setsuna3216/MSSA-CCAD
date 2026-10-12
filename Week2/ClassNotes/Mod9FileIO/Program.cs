using System.IO;
namespace Mod9FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
           const string path = @"C:\Files\";
            Console.WriteLine("Exploring File IO operations..");
            Console.WriteLine("Enter a file name to create :");
            string filename = path + Console.ReadLine() + ".txt";
            StreamWriter writer=null;
            try
            {
                if(!File.Exists(filename))
                {
                    writer = File.CreateText(filename);
                    writer.WriteLine("New file is created at " + DateTime.Now);
                    Console.WriteLine("File created successfully!");
                }
                else
                {
                    
                    File.AppendAllText(filename, $"\nFile accessed on {DateTime.Now}");
                    Console.WriteLine("File appended successfully!");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(writer!=null)
                {
                    writer.Close();
                }
            }

            Console.WriteLine("Reading file content:");

            try
            {
                //giving a scope to the stream reader
                using(StreamReader sr=new StreamReader(filename))
                {
                    Console.WriteLine(sr.ReadToEnd());

                }
               

            }
            catch(Exception ex)
            {

            }
            finally
            {
                

            }
        
        
        }
    }
}
