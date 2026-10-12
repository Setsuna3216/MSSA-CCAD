namespace Mod4Generics
{
    internal class Program
    {
        //  generic collections are highly type safe collection classes that allow you to reuse the
        //template for different data types
        // avoids boxing - unboxing 
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = 34;
            num2 = 100;

            long n3 = 700, n4 = 33;
            float n1=3.4f, n2=6.7f;
            num1 = (int)n3;
            Swap<int> swapint = new Swap<int>();
            swapint.SwapData(ref num1, ref num2);
        

            Swap<float> swapfloat = new Swap<float>();
            swapfloat.SwapData(ref n1, ref n2);
            List<int> data = new List<int>();

        }
        static void Swap(ref int num1,ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Swap(ref float num1, ref float num2)
        {
            float temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Swap(ref double  num1, ref double num2)
        {
            double temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
