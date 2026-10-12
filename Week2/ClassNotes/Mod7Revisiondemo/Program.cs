
    namespace Mod7Revisiondemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Abstraction
             *2. Encapsulation
             *3.Inheritance
             *4.Polymorphism : dynamic(overriding), static(overloading)
             * 
             * 
             */


            B obj1 = new B();
            obj1.VirtualMethod();
            var obj2 = new B();
            A obj3 = new B();
            obj3.VirtualMethod();
            A obj4 = new C();
            obj4.VirtualMethod();

            //  B obj4 = new A(); not valid

            // File.Create("ss");

            try
            {
                //conditions
                throw new CustomException();

            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
