using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Baseclass
    {
        public Baseclass()
        {
            Console.WriteLine("Baseclass Constructor...");
        }
    }
    class Derived : Baseclass
    {
        public Derived()
        {
            Console.WriteLine("Derivedclass Constructor...");
        }
    }
    class DerivedConstructor
    {
        static void Main(string[] args)
        {
            Derived obj = new Derived();
            Console.WriteLine("in the main...");
        }
    }
}
