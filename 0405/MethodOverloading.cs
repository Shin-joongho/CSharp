using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Method
    {
        public void Somethig()
        {
            Console.WriteLine("SomeThing() is called");
        }
        public void Something(int i)
        {
            Console.WriteLine("SomeThing(int i) is called");
        }
        public void Something(int i,int j)
        {
            Console.WriteLine("SomeThing(int i, int j) is called");
        }
        public void Something(double d)
        {
            Console.WriteLine("SomeThing(double d) is called");
        }
    }
    class MethodOverloading
    {
        static void Main(string[] args)
        {
            Method obj = new Method();
            obj.Somethig();
            obj.Something(526);
            obj.Something(54, 526);
            obj.Something(5.26);
        }
    }
        
}
