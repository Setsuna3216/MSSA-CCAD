namespace PhoneBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Person obj = new Person();
            obj.FirstName = "Alice";
            obj.LastName = "Scott";
            obj.Address = "NY";
            obj.WorkPhone = 1223344;

            Data.PhoneBook.Add(obj.FirstName + obj.LastName, obj);
            Data.PhoneBook.Add("DeepaliK", new Person() { WorkPhone = 343343, Address = "NJ", FirstName = "Deepali", LastName = "K" });
            Application.Run(new Form1());
        }
    }
}