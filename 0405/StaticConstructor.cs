using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Constructor

    {
        static int staticWithInitalizer = 100;
        static int staticWithNoInitializer;
        Constructor()
        {
            staticWithNoInitializer = staticWithInitalizer + 100;
        }
        public static void PrintStaticVariable()
        {
            Console.WriteLine("field 1={0}, field 2={1}", staticWithInitalizer, staticWithNoInitializer);
        }
    }
    class StaticConstructor
    {
        static void Main(string[] args)
        {
            Constructor.PrintStaticVariable();
        }
    }
        
}
