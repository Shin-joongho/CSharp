using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Baseclass
    {
        public virtual void Output()
        {
            Console.WriteLine("In the Base class");
        }
    }
    class Derivedclass : Baseclass
    {
        public override void Output()
        {
            Console.WriteLine("In the Derived class");
        }
    }
    
    class Polymorphism
    {
        static void Print(Baseclass obj)
        {
            obj.Output();
        }
        static void Main(string[] args)
        {
            Baseclass obj1 = new Baseclass();
            Derivedclass obj2 = new Derivedclass();
            Print(obj1);
            Print(obj2);
        }
    }
}
