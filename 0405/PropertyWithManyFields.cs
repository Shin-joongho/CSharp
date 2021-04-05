using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class WithManyFields
    {
    private string text = "Dept. of software";
    private bool isModified = false;
    public string Text
     {
                get
                {
                    return text;
                }
                set
                {
                    text = value; isModified = true;
                }
            }
            public void PrintStatus()
            {
                Console.WriteLine("text is \"" + text + "\",and" + (isModified ? "is" : "not") + "modified");
            }
    }
    
    class PropertyWithManyFields
    {
        static void Main(string[] args)
        {
            WithManyFields obj = new WithManyFields();
            obj.PrintStatus();
            obj.Text = "Programming Language Lab";
            obj.PrintStatus();
        }
    }
        
}
