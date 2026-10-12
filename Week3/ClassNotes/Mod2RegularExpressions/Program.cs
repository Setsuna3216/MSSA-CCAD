using System.Text.RegularExpressions;

namespace Mod2RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Regex : regular expressions help us match patterns in order to validate inputs
        //used in front end layer
        input:
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            if(ContainsDigits(name))
            {
                Console.WriteLine("Name should not contain digits, please re enter");
                goto input;
            }
            else
            {
            emailinput:
                Console.WriteLine($"{name}, please enter your email");
                var email = Console.ReadLine();//deep@gmail.ar
                if(CheckEmail(email))
                {
                    Console.WriteLine($"Welcome {name}, you are registered with {email} ");
                }
                else
                {
                    Console.WriteLine("Invalid format, please enter email again..");
                    goto emailinput;
                }

            }


        }

        static bool CheckEmail(string email)
        {
            string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailpattern);
        }
        static bool ContainsDigits(string name)
        {
           return  Regex.IsMatch(name, @"\d");
        }
    }
}
