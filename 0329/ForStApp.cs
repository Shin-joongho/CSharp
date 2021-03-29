using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ForStApp
    {
        static void Main(string[] args)
        {
            int i, n;
            double h = 0.0;
            Console.Write("Enter a number=");
            n = Console.Read() - '0';
            for (i = 1; i <= n; i++)
                h = h + 1 / (double)1;
            Console.WriteLine("n={0},h={1}", n, h);

        }
    }
}
