using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphismdemo
{// normal instance classes,  1 to many
    internal class Student:Person
    {

        public override void FollowSchedule()
        {
            Console.WriteLine("I am in virtual online sessions from 9 to 5.");
          //  throw new NotImplementedException();
        }
        public override void DoWork()
        {
            base.DoWork();
            //own logic
            Console.WriteLine("I am doing my major in Computer Science");
        }
    }
}
