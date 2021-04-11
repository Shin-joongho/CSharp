using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6 {
  


public class StackNode
{
    char data;
    StackNode link;
}

class LinkedStack
{
    private StackNode top;

    Boolean isEmpty()
    {
        return (top == null);
    }
        public void Push(char item)
    {
    StackNode newNode = new StackNode();
    newNode.data = item;
    newNode.link = top;
    top = newNode;
    }
    public char Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail");
            }
            else
            {
                char item = top.data;
                top = top.link;
                return item;
            }
        }
    public void delete()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail");
            }
            else
            {
                top = top.link;
            }
        }
        public char peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Deleting fail");
            }
            else
            {
                return top.data;
            }
        }
        public void printStack()
        {if (isEmpty())
            {
                Console.WriteLine("Deleting fail");
            }
            else
            {
                StackNode temp = top;
                Console.WriteLine("Linked Stack>>");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.link;
                }
            }
        }


}
    public class OptExp
    {
        private String exp;
        private int expSize;
        private char testCh, openPair;
        
        public Boolean testPair(String exp)
        {
            this.exp = exp;
            LinkedStack S = new LinkedStack();
            expSize = this.exp.Length;
            for(int i = 0; i < expSize; i++)
            {
                testCh = this.exp[i];
                switch (testCh)
                {
                    case '(':
                    case '{':
                    case '[':
                        S.Push(testCh);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (S.isEmpty())
                            return false;
                        else
                        {
                            openPair = S.Pop();
                            if ((openPair == ('(' && testCh != ')')
                                || (openPair == '{' && testCh != '}') || (openPair == '[' && testCh != ']'))
                                return false;
                            else
                                break;
                        }

                }
            }
            if (S.isEmpty())
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OptExp opt = new OptExp();
            String exp = "(3*5)-6/2)";

            Console.WriteLine(exp);

            if (opt.testPair(exp))
                Console.Write("괄호 맞음");
            else
                Console.Write("괄호 틀림");
        }
    }
}
