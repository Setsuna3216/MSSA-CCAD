namespace Mod3Delegates2
{
    internal class Program
    {
        delegate int Operation(int a, int b);
        static int Multiply(int a,int b)
        {
            return a * b;
        }
        static int Add(int n1,int n2)
        {
            return n1 + n2;
        }
        //using delegate as argument, passing logic to this method
        static void Calculate(int x,int y,Operation op)
        {
            int result = op(x, y);//delegate call
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Operation d = new Operation(Add);
            //sending method name as arguement to another method
            Calculate(23, 34, Add);

            Calculate(12, 34, Multiply);
        }
    }
}
