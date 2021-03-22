using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Console
    {
        static void Main(string[] args)
        {
            System.Console.Write("Hello ");
            System.Console.WriteLine("World!");
            System.Console.Write("이름을 입력하세요: ");
            string name = System.Console.ReadLine();
            System.Console.Write("안녕하세요, ");
            System.Console.Write(name);
            System.Console.WriteLine("님!");

        }
    }
}
