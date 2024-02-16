using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class DerivedClass : Class_A
    {
        public  override void Met2()
        { 
            base.Met2();
            WriteLine("Мет2 из дочернего класса DerivedClass");
        
        }
        public  override void Met3()
        {

            WriteLine("Мет3 из абс. класса Class_A, реализованный в DerivedClass");
        }
        public override void Met4()
        {
            WriteLine("Мет4 из абс. класса Class_A, реализованный в DerivedClass");
        }
    }
}
