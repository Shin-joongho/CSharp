using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp8
{
    class DivByZeroExcept2
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("3개의 정수를 입력하세요 : ");
            int sum = 0, n = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " >> ");
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine("합은 " + sum);
        }
    }
}
