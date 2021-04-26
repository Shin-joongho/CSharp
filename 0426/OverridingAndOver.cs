using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Baseclass
    {
        public void MethodA()
        {
            Console.WriteLine("in the BaseClass...");
        }
    }
    class Derived : Baseclass
    {
        new public void MethodA()
        {
            Console.WriteLine("in DerivedClass...Overriding!");
        }
        public void MethodA(int i)
        {
            Console.WriteLine("in DerivedClass...Overriding!");
        }
    }
    class OverridingAndOver
    {
        static void Main(string[] args)
        {
            Baseclass obj1 = new Baseclass();
            Derived obj2 = new Derived();
            obj1.MethodA();
            obj2.MethodA();
            obj2.MethodA(1);
        }
    }
}
