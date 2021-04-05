using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class DisposeClass : IDisposable
    {
       public void Dispose()
        {
            Console.WriteLine("In the Dispose...");
            GC.SuppressFinalize(this);
        }
    }
    class DisposeApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Star of Main");
            using (DisposeClass obj=new DisposeClass())
            {

            }
            Console.WriteLine("End of Main");
        }
    }
        
}
