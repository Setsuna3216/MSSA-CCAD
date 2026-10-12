namespace Mod3Delegates1
{
    // i can point to any accessible method which returns void and takes in 1 string argument
    public delegate void Greeting(string name);
    delegate int CalculateDelegate(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //function call
           // SayHello("Jay");


            //delegate call:
            Greeting mygreeting = new Greeting(SayHello);//mygreeting points to method SayHello
           
            //function chaining
            mygreeting += SayHi;
            mygreeting("James");

            //  mygreeting -= SayHi;

            CalculateDelegate d = Add;
            int result = d(34,12);
            Console.WriteLine(result);

            d = Subtract;

            Console.WriteLine(d(45, 23));
        }
        //logic
        static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}");
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
        static int Subtract(int a,int b)
        {
            return a - b;
        }
    }
}
