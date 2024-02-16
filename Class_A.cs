using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Class_A
    {
        public void Met1()
        {
            WriteLine("Обычный метод из абс. класса Class_A");
        
        }
        public virtual void Met2()
        {
            WriteLine("Вирт. met2 из абс. класса Class_A");    
        }
        public abstract void Met3();
        public abstract void Met4();

    }
}
