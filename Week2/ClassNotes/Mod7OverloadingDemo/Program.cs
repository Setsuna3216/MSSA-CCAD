namespace Mod7OverloadingDemo
{
    internal class Program
    {
        //design time
        //overloading: same method names within same class with different type , number of arguments
        static void Main(string[] args)
        {
            Add(3, 4);
            Add(2.3f, 4.5f);
            Service service = new Service(230);
            service.ServiceName = "Toggle switches";
            service.StartService("deepali");
            Service.

        }

        static int Add(int a,int b)
        {
            return a + b;
        }
        static int Add(int a, int b,int c)
        {
            return a + b+c;
        }

        static float Add(float a,float b)
        {
            return a + b;
        }
    }
}
