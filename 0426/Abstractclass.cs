using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    abstract class Abstract
    {
        public abstract void MethodA();
        public void MethodB()
        {
            Console.WriteLine("Implementation of MethodB()");
        }
    }
    class Impclass : Abstract
    {
        override public void MethodA()
        {
            Console.WriteLine("Implementation of MethodA()");
        }
    }
    class Abstractclass
    {
        static void Main(string[] args)
        {
            Impclass obj = new Impclass();
            obj.MethodA();
            obj.MethodB();
        }
    }
}
