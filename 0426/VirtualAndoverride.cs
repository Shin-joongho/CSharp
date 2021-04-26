using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class CLang
    {
        virtual public void Print()
        {
            Console.WriteLine("In the Clang class");
        }
    }
    class Java : CLang
    {
        public override void Print()
        {
            Console.WriteLine("In the Java class");
        }
    }
    
    class VirtualAndoverride
    {
        static void Main(string[] args)
        {
            CLang c = new Java();
            c.Print();
        }
    }
}
