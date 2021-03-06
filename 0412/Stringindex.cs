using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class StringIndexer
    {
        public char this[string str, int index]
        {
            get { return str[index]; }
        }
        public string this[string str, int index,int len]
        {
            get { return str.Substring(index, len); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            StringIndexer s = new StringIndexer();
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine("{0}[{1}]={2}", str, i, s[str, i]);
            Console.WriteLine("substring of {0} is {1}",str, s[str, 2, 3]);
        }
    }
}
