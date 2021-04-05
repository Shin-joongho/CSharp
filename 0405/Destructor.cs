using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Des
    {
       public Des()
        {
            Console.WriteLine("In the constructor..");
        }
        ~Des()
        {
            Console.WriteLine("In the destructor..");
        }
    }
    class Destructor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Star of Main");
            Des d = new Des();
            Console.WriteLine("End of Main");
        }
    }
        
}
