using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class CommandLine
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
                Console.WriteLine("Argument[{0}]={1}", i, args[i]);
        }
    }
        
}
