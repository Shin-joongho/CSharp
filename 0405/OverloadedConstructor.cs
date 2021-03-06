using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Fraction
    {
        int numerator;
        int denominator;

        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int n)
        {
            numerator = n;
            denominator = 1;
        }
        public Fraction(int n,int d)
        {
            numerator = n;
            denominator = d;
        }
        public override string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    class OverloadedConstructor
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction(2);
            Fraction f3 = new Fraction(1, 2);
            Console.WriteLine("f1={0}, f2={1}, f3={2}", f1, f2, f3);
        }
    }
        
}
