using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class CLang
    {
        public bool Equal(object obj)
        {
            
             if (obj is CLang)
                 return true;
             else
                 return false;
        }
    }
    class CSharp : CLang
    {
        new public bool Equal(object obj)
        {
            return (obj is CSharp) ? true : false;
        }
    }
    
    class ClassTypeconversion
    {
        static void Main(string[] args)
        {
            CLang c = new CLang();
            CSharp cs = new CSharp();
            if (c.Equal(cs))
                Console.WriteLine("casting up is valid.");
            else
                Console.WriteLine("casting up is not valid.");
            if (cs.Equal(c))
                Console.WriteLine("casting down is valid.");
            else
                Console.WriteLine("casting down is not valid.");
        }
    }
}
