using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class AnoterBlockApp
    {
        static void Main(string[] args)
        {
            int x = 1;
            {
                int y = 2;
                Console.WriteLine("Block 1:x=" + x + "y=" + y);
            }
            {
                int y = 3;
                Console.WriteLine("Block 2:x=" + x + "y=" + y);
            }
            
        }
    }
}
