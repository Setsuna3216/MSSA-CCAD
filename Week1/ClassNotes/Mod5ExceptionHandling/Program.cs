namespace Mod5ExceptionHandling
{
    internal class Program
    {//4o
        static void Main(string[] args)
        {
            int num1, num2;
            float result=0;
            
            Console.WriteLine("Enter 2 numbers..");


          input:
            Console.WriteLine("Enter first number:");
            //40 //4oo
            bool isNum1Valid = int.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Enter second number:");
            bool isNum2Valid = int.TryParse(Console.ReadLine(), out num2);
            int[] numbers = { 1, 23 };
            try
            {
               // numbers[2] = 45;
                if (isNum1Valid && isNum2Valid)
                { 
                    result = num1 / num2;
                    Console.WriteLine($"result is {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input, Please enter valid integers");
                    goto input;
                }

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                //log errors in log file/ db for further analysis
            }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //this block of code executes even if error occurs or not
                // mandatory code: close file handles, close db connections
            }

        }

        //static bool tryparse(string s,out int result)
        //{
        //    result = 0;
        //    //logic
        //    return true;
        //}
    }
}
