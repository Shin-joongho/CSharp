using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Baseclass
    {
        protected int a = 1;
        protected int b = 1;
    }
    class Derilved : Baseclass
    {
        new int a = 3;
        new double b = 4.5;
        public void Output()
        {
            Console.WriteLine("BaseClass : a={0}, DerivedClass : a={1}", base.a, a);
            Console.WriteLine("BaseClass : b={0}, DerivedClass : b={1}", base.b, b);
        }
    }
    class HiddenNameApp
    {
        static void Main(string[] args)
        {
            Derilved obj = new Derilved();
            obj.Output();
        }
    }
}
