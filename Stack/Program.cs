using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.Write("isi stack 1 = ");
            foreach (int i in myStack)
                Console.Write(i);
            Console.WriteLine();

            myStack.Pop();
            Console.Write("isi stack 2 = ");
            foreach (int i in myStack)
                Console.Write(i);
            Console.WriteLine();

            myStack.Pop();
            Console.Write("isi stack 3 = ");
            foreach (int i in myStack)
                Console.Write(i);
            Console.WriteLine();

            myStack.Pop();
            Console.Write("isi stack 4 = ");
            foreach (int i in myStack)
                Console.Write(i);
            Console.WriteLine();

            Console.Read();
        }
    }
}
