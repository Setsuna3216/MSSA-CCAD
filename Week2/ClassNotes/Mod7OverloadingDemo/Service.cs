using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7OverloadingDemo
{
    internal class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public bool IsRunning { get; set; } = false;

        public static void Test()
        {

        }

        public Service()
        {
            ServiceId = 100;
            ServiceName = "Test";
            IsRunning = false;
        }
        public Service(int id )
        {
            ServiceId = id;
        }

        public void StartService()
        {
            IsRunning = true;
            Console.WriteLine($"{ServiceName} is started..");

        }
        public void StartService(string username)
        {
            IsRunning = true;
            Console.WriteLine($"{ServiceName} is started by {username}");
        }



    }
}
