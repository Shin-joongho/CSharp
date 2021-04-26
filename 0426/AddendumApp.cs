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
            Console.WriteLine("do Baseclass task");
        }
    }
    class Derivedclass : Baseclass
    {
        new public void MethodA()
        {
            base.MethodA();
            Console.WriteLine("do Derivedclass task");
        }
    }
    class AddendumApp
    {
        static void Main(string[] args)
        {
            Derivedclass obj = new Derivedclass();
            obj.MethodA();
        }
    }
}
