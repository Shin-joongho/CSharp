﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CalculatorApp
    {
        static void Main(string[] args)
        {
            int x, y, r = 0;
            char opr;
            Console.Write("Enter an operator & two number=");
            opr = (char)Console.Read();
            x = Console.Read() - '0';
            y = Console.Read() - '0';
            switch (opr)
            {
                case '+':r = x + y;
                    Console.WriteLine(x + "+" + y + "=" + r);break;
                case '-':r = x - y;
                    Console.WriteLine(x + "-" + y + "=" + r);break;
                case '*':r = x * y;
                    Console.WriteLine(x + "*" + y + "=" + r);break;
                case '/':r = x / y;
                    Console.WriteLine(x + "/" + y + "=" + r);break;
                default:Console.WriteLine("lllegal operator");break;
            }
        }
    }
}