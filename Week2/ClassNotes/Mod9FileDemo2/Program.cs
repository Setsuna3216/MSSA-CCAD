namespace Mod9FileDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo drive = new DriveInfo("C");
            Console.WriteLine($"Drive name:{drive.Name} , drive type: {drive.DriveType} total size:{drive.TotalSize}");

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Files\");
            var directories = directoryInfo.GetDirectories();
            foreach(var dir in directories)
            {
                Console.WriteLine($"Directory name: {dir.Name} created at {dir.CreationTime}");
                //var filearray = dir.GetFiles();
                //foreach(var f in filearray)
                //{

                //}
            }

            var files = directoryInfo.GetFiles();
            foreach(var file in files)
            {
                Console.WriteLine($"filename:{file.Name} created at {file.CreationTime} with size {file.Length} ");
            }


        }
    }
}
