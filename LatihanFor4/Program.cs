using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanFor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            /*for (i = 1; i <= 5; i++)
            {
              
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 5; k >=i ; k--)
                {
                    Console.Write(" *");
                }
                    Console.WriteLine("");
            }*/
            i = 1;
            while ( i <= 5)
            {
                j = 5;
                do
                {
                    Console.Write(" ");
                    j--;
                }
                while ( j >= i );
                k = 1;
                while ( k <= i)
                {
                    Console.Write(" *");
                    k++;
                }
                Console.WriteLine("");
                i++;
            }
            Console.Read();
        }
    }
}
