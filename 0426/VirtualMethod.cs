using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Baseclass
    {
        virtual public void MethodA()
        {
            Console.WriteLine("Base MethodA");
        }
        virtual public void MethodB()
        {
            Console.WriteLine("Base MethodB");
        }
        virtual public void MethodC()
        {
            Console.WriteLine("Base MethodC");
        }
    }
    class Derived : Baseclass
    {
        new public void MethodA()
        {
            Console.WriteLine("Derived MethodA");
        }
        new public void MethodB()
        {
            Console.WriteLine("Derived MethodB");
        }
        new public void MethodC()
        {
            Console.WriteLine("Derived MethodC");
        }
    }
    class VirtualMethod
    {
        static void Main(string[] args)
        {
            Baseclass s = new Derived();
            s.MethodA();
            s.MethodB();
            s.MethodC();
        }
    }
}
