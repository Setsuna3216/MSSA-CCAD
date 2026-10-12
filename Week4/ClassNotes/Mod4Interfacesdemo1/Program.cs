namespace Mod4Interfacesdemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //not allowed to create instance of interfaces
            //IGreeting obj = new IGreeting();

            IGreeting g = new ReportGenerator();
            

            ReportGenerator report = new ReportGenerator();
           Console.WriteLine( report.DisplayGreeting("deepali"));

            IGreeting  web = new WebGenerator();
            Console.WriteLine(web.DisplayGreeting("deepali"));
        }
    }
}
