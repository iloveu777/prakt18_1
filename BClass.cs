using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp2
{
    internal abstract class BClass : AClass
    {
        public abstract void Sum(ref int x,ref   int y);
        


    }
}
