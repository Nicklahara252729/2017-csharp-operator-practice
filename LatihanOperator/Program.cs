using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string bil_a, bil_b;
            double a, b,hasil,hasil2,hasil3,hasil4;
            Console.Write("\n Input bilangan 1 ");
            bil_a = Console.ReadLine();
            Console.Write(" Input bilangan 2 ");
            bil_b = Console.ReadLine();
            a = Convert.ToInt16(bil_a);
            b = Convert.ToInt16(bil_b);
            hasil = a + b;
            hasil2 = a - b;
            hasil3 = a * b;
            hasil4 = a / b;
            Console.WriteLine("\n Hasil penjumlahan {0}",hasil);
            Console.WriteLine(" Hasil pengurangan {0}", hasil2);
            Console.WriteLine(" Hasil perkalian {0}", hasil3);
            Console.WriteLine(" Hasil pembagian {0}", hasil4);
            Console.Read();
        }
    }
}
