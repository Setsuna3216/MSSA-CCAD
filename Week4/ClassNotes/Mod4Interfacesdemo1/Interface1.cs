using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interfacesdemo1
{
    interface I1
    {
        void Test();
    }
    interface I2
    {
        void Test();
    }

    class Implementor : I1, I2
    {
        void I1.Test()
        {
            throw new NotImplementedException();
        }

        void I2.Test()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IGreeting
    {
        //by default the access specifier is public
        string DisplayGreeting(string name);
    }

    class ReportGenerator : IGreeting
    {
        public string DisplayGreeting(string name)
        {
            return "Hello " + name;
        }
        public void Test()
        {

        }
    }

    class WebGenerator : IGreeting
    {
        string IGreeting.DisplayGreeting(string name)
        {
            return "Welcome " + name;
        }
    }

}
