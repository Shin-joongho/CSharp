using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp8
{
    class Propagate
    {
        public void Orange()
        {
            int i = 25, j = 0;
            i = i / j;
            Console.WriteLine("End of Orange method");
        }
        public void Apple()
        {
            Orange();
            Console.WriteLine("End of Apple method");
        }
    }

    class SystemHandler
    {
        static void Main(string[] args)
        {
            Propagate p = new Propagate();
            try
            {
                p.Apple();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ArithmeticException is processed");
            }
            Console.WriteLine("End of Main");
        }
    }
}
