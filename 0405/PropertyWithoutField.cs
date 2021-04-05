using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class WithoutField
    {
        public string Message
        {
            get
            {
                return Console.ReadLine();
            }
            set
            {
                Console.WriteLine(value);
            }
        }
    }
    
    class PropertyWithoutField
    {
        static void Main(string[] args)
        {
            WithoutField obj = new WithoutField();
            obj.Message = obj.Message;
        }
    }
        
}
