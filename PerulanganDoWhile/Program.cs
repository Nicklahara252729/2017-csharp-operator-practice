using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerulanganDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do{
                Console.WriteLine("\n Nilai i = "+i);
                i++;
            }
            while(i<=5);
                Console.Read();
        }
    }
}
