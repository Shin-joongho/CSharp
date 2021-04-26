using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp8
{
    public class MyAttrAttribute : Attribute
    { // 속성 클래스
        public MyAttrAttribute(string message)
        { // 생성자
            this.message = message;
        }
        private string message;
        public string Message
        { // 프로퍼티
            get { return message; }
        }
    }
    [MyAttr("This is Attribute test.")]


    class Myattribute
    {
        
        static void Main(string[] args)
        {
            Type type = typeof(Myattribute);
            object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true);
            if (arr.Length == 0)
                Console.WriteLine("This class has no custom attrs.");
            else
            {
                MyAttrAttribute ma = (MyAttrAttribute)arr[0];
                Console.WriteLine(ma.Message);
            }


        }
    }
}
