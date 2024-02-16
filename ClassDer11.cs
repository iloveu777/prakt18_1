using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class ClassDer11 : CClass
    {
        public override void Method()
        {
            Write("абс. метод из ACLass и переопределенный в CLassDer11");
        }
        public override void Sum(ref  int x, ref  int y)
        {
             WriteLine(x+ y);
        }
        public override string Hello(string message)
        {
            return message;
        }
    }
}
