using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Color
    {
        public const int FULL = 0xFF;
        public const int EMPTY = 0x00;
        private byte red, green, blue;
        public static readonly Color Red = new Color(FULL, EMPTY, EMPTY);
        public static readonly Color Green = new Color(EMPTY, FULL, EMPTY);
        public static readonly Color Blue = new Color(EMPTY, EMPTY, FULL);
        public Color(byte r, byte g, byte b)
        {
            red = r;
            green = g;
            blue = b;
        }
        public static void PrintColor(Color c)
        {
            Console.WriteLine("red value ={0}, green value ={1}, blue value ={2}", c.red, c.green, c.blue);
        }
    }
    class ConstVsReadOnlyApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FULL=" + Color.FULL);
            Color.PrintColor(Color.Blue);
        }
    }
        
}
