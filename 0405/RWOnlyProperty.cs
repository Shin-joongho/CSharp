using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class RWOnly
    {
        private int readOnly = 100;
        private int writeOnly;
        public int ReadOnlyProperty
        {
            get
            {
                Console.WriteLine("In the ReadOnlyProperty...");
                return readOnly;
            }
        }
        public int WriteOnlyProperty
        {
            set
            {
                Console.WriteLine("In the WriteOnlyPropoerty...");
                writeOnly = value;
            }
        }
    }
    
    class RWOnlyProperty
    {
        static void Main(string[] args)
        {
            RWOnly obj = new RWOnly();
            obj.WriteOnlyProperty = obj.ReadOnlyProperty;
            Console.WriteLine("value=" + obj.WriteOnlyProperty);//compiler Error
        }
    }
        
}
