using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        public override string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    class Property
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction();
            int i;
            f.Numerator = 1;
            i = f.Numerator + 1;
            f.Denominator = i;
            Console.WriteLine(f.ToString());
        }
    }
        
}
