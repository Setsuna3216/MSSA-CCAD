using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Revisiondemo
{
    
    internal class CustomException:Exception
    {
        public override string Message
        {
            get
            {

                return "This is my custom exception";
            }

        }
    }
}
