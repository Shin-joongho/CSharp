using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
#define CSHARP

namespace ConsoleApp8
{
    class ConditionalAttr
    {
        [Conditional("CSHARP")]
        public static void CsharpMethod()
        {
            Console.WriteLine("In the CSharp Method ...");
        }
        [Conditional("JAVA")]
        public static void JavaMethod()
        {
            Console.WriteLine("In the Java Method ...");
        }
    }


    class ConditionalAtt
    {
        
        static void Main(string[] args)
        {
            ConditionalAttr.CsharpMethod();
            ConditionalAttr.JavaMethod();

        }
    }
}
