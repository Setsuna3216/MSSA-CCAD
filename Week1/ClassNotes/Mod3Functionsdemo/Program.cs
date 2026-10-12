namespace Mod3Functionsdemo
{
    internal class Program
    {
       static int i;

        static void Main(string[] args)
        {

            // only call static methods from another static method directly
            // calling method

            DisplayGreeting("deepali", "how are you");
            int n1, n2;
            Console.WriteLine("enter 2 numbers");
            Console.WriteLine("Enter number 1 now..");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 now..");
            n2 = Convert.ToInt32(Console.ReadLine());
            int result= AddNumbers(n1, n2);// call 
           Console.WriteLine("the result is" + result);
        }

        static void DisplayGreeting(string name,string greetingmsg)
        {
            Console.WriteLine($"{greetingmsg}! {name} ");
        }
     
        //declaration
        // static returntype name(argument list)
        static int AddNumbers(int n1,int n2)// arguments
        {
            
            int sum = n1 + n2;
            return sum;
           // int i;
        }



    }
}
