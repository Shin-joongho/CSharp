using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Baseclass
    {
        public int a, b;
        public Baseclass()
        {
            a = 1;b = 1;
        }
        public Baseclass(int a,int b)
        {
            this.a = a; this.b = b;
        }
    }
    class Derived : Baseclass
    {
        public int c;
        public Derived()
        {
            c = 1;
        }
        public Derived(int a,int b,int c):base(a,b)
        {
            this.c = c;
        }
    }
    class BaseCall
    {
        static void Main(string[] args)
        {
            Derived obj1 = new Derived();
            Derived obj2 = new Derived(1, 2, 3);
            Console.WriteLine("a = {0}, b = {1}, c = {2}",
            obj1.a, obj1.b, obj1.c);
            Console.WriteLine("a = {0}, b = {1}, c = {2}",
            obj2.a, obj2.b, obj2.c);
        }
    }
}
