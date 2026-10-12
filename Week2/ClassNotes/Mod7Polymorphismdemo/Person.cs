using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Polymorphismdemo
{
    // abstract classes cannot be instantiated, treated as base of your class hierarchy
    internal abstract class Person
    {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    //normal methods
    public void Introduce()
     {
            Console.WriteLine($"Hello , I am {FirstName}  {LastName} and i am {Age} years old");
     }
    //virtual allows us to override/ make changes in the logic in derived classes
    public virtual void DoWork()
    {
            Console.WriteLine("I am working..");
    }
        // abstract methods
        // these methods only belong to abstract classes, do not have method body
        //must be implemented in derived classes
        public abstract void FollowSchedule();
          

    }
}
