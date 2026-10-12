using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Revisiondemo
{
    internal abstract class A
    {
        //normal properties, member variables
        //normal method
        public void NormalMethod()
        {

        }
        //virtual methods
        public virtual void VirtualMethod()
        {

        }
        //abstract methods
        public abstract void AbstractMethod();
    }
    class B:A
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("in class B implementation");
        }
        public override void VirtualMethod()
        {
          //  base.VirtualMethod();// gives you access to base class function
            Console.WriteLine("in class B implementation");
        }
        public virtual  void VirtualMethod(int i)
        {
            Console.WriteLine("created in class B");

        }
    }
    class C:B
    {
        public override void VirtualMethod()
        {
            // base.VirtualMethod();
            Console.WriteLine("in class C");
        }
        public override void VirtualMethod(int i)
        {
            //   base.VirtualMethod(i);
            Console.WriteLine("in class C");
        }
    }

}
