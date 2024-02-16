using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Met1();
            derivedClass.Met2();
            derivedClass.Met3();
            derivedClass.Met4();
            */
            ClassDer11 classDer11 = new ClassDer11();
            string aaa = "Hello";
            WriteLine(classDer11.Hello(aaa));
            int a = 10;
            int b = 20;
            classDer11.Sum(ref a, ref b);

            ReadKey();
        }
    }
}
