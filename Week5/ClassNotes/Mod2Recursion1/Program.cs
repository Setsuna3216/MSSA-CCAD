namespace Mod2Recursion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = @"C:\Training";
            string[] directories = Directory.GetDirectories(path);
            PrintDirectories(path, 1);
            #region Iteration
            //foreach (string dir in directories)
            //{
            //    Console.WriteLine(dir);
            //    string[] subdirs = Directory.GetDirectories(dir);
            //    foreach (var item in subdirs)
            //    {
            //        Console.WriteLine(item);
            //        string[] sub_subdirs = Directory.GetDirectories(item);
            //        foreach (var d in sub_subdirs)
            //        {
            //            Console.WriteLine(d);
            //        }
            //    }

            //} 
            #endregion
        
        
        }

        static void PrintDirectories(string path,int depth)
        {
            string[] directories = Directory.GetDirectories(path);
            foreach(string d in directories)
            {
                Console.WriteLine(d);
                if(depth>0)// base condition
                {
                    PrintDirectories(d, depth - 1);
                }
            }
        }



    }
}
