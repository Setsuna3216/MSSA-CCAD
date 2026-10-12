using System.Security.Cryptography.X509Certificates;

namespace Mod2MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //named arguments
           // CalculateSalary(5000, "NC", 300, 2, 'S');
            CalculateSalary(baseSalary: 4000, contributions: 500, state: "NJ", dependants: 1, filingStatus: 'J');

            int sum, prod;
            int[] input = { 34, 56, 78 };
            MathOperations(out sum, out prod, input);

            MathOperationswithParams(out sum, out prod, 12, 34, 56, 78, 90);
            
        }

        static void CalculateSalary(double baseSalary,double contributions,int dependants, string state = "NY",char filingStatus='S')
        {

        }

        static void MathOperations(out int sum, out int prod,int[]args)
        {
            // sum = i + j;
            //prod = i * j;
            sum = 0;
            prod = 1;
            foreach(var num in args)
            {
                sum = sum + num;
                prod = prod * num;
            }
        }
        static void MathOperationswithParams(out int sum, out int prod, params int[] args)
        {
            // sum = i + j;
            //prod = i * j;
            sum = 0;
            prod = 1;
            foreach (var num in args)
            {
                sum = sum + num;
                prod = prod * num;
            }
        }
        //static void MathOperations(out int sum, out int prod, int i, int j, int k)
        //{
        //    sum = i + j+k;
        //    prod = i * j*k;
        //}
    }
}
