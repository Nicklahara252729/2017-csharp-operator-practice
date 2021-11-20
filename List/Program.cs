using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            Console.WriteLine("\n isi list");
            foreach (int i in myList)
                Console.Write(" {0}", i);
            Console.WriteLine();

            myList.Remove(1);
            Console.WriteLine("\n isi list");
            foreach (int i in myList)
                Console.Write(" {0}", i);
            Console.WriteLine();

            myList.Clear();
            Console.WriteLine("\n isi list");
            foreach (int i in myList)
                Console.Write(" {0}", i);
            Console.WriteLine();

            Console.Read();
        }
    }
}
