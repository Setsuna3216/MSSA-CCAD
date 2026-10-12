using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphismdemo
{
    internal class Instructor:Person
    {

        public override void FollowSchedule()
        {
            Console.WriteLine("I teach from 9 to 5 online");
        }
        public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("I teach CAD track, check assignments..");
        }
    }
    class PartTimeInstructor:Instructor
    {
        
        public override void FollowSchedule()
        {
            base.FollowSchedule();
            Console.WriteLine("I conduct labs from 2 to 5");
        }
        public override void DoWork()
        {
         
            Console.WriteLine("I conduct C# labs");
        }

    }

}
