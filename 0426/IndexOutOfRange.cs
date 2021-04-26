using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp8
{
    class IndexOutOfRange
    {
        
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3 };
            vector[4] = 4;
        }
    }
}
