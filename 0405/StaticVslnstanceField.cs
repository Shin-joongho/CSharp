using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class StaticVslnstanceField
    {
        public int instanceVariable;
        public static int staticVariable;
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticVslnstanceField obj = new StaticVslnstanceField();
            obj.instanceVariable = 10;
            StaticVslnstanceField.staticVariable = 20;
            Console.WriteLine("instance variable={0}, static variable={1}", obj.instanceVariable, StaticVslnstanceField.staticVariable);
        }
    }
        
}
