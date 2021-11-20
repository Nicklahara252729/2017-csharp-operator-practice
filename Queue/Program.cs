using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            Console.Write(" isi queue 1 : ");
            foreach (int i in myQueue)
                Console.Write(i);
            Console.WriteLine();

            myQueue.Dequeue();
            Console.Write(" isi queue 2 : ");
            foreach (int i in myQueue)
                Console.Write(i);

            myQueue.Dequeue();
            Console.Write("\n isi queue 3 : ");
            foreach (int i in myQueue)
                Console.Write(i);

            myQueue.Dequeue();
            Console.Write("\n isi queue 4 : ");
            foreach (int i in myQueue)
                Console.Write(i);
            Console.WriteLine();

            Console.Read();
        }
    }
}
