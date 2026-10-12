namespace Mod7ClassHierarchydemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount();
            savings.AccountNumber = 243434;
            savings.AccountHolder = "Jane Smith";
            savings.Balance = 400.00m;

            CheckingAccount checking = new CheckingAccount();
            checking.Balance = 50m;
            
               
        }
    }
}
