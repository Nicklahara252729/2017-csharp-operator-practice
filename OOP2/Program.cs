using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        public static string bil1, bil2, operat;
        public static int Cbil1, Cbil2, hasil;
        static void Main(string[] args)
        {
            Program oop2 = new Program();
            Program obj = new Program();

            obj.inputan();  
          
            if(operat == "+"){
                oop2.penjumlahan();
            }else if(operat == "-"){
                oop2.pengurangan();
            }
            else if (operat == "*")
            {
                oop2.perkalian();
            }else if(operat == "/"){           
                oop2.pembagian();
            }
            else
            {
                Console.Write(" Operator tidak tersedia !");
            }
            Console.Read();

        }

        public int penjumlahan()
        {
            hasil = Cbil1 + Cbil2;
            Console.WriteLine("hasil penjumlahan = {0}", hasil);
            return hasil;
           
        }

        public int pengurangan()
        {
            hasil = Cbil1 - Cbil2;
            Console.WriteLine(" hasil pengurangan " + hasil);
            return hasil;
        }

        public int perkalian()
        {
            hasil = Cbil1 * Cbil2;
            Console.WriteLine(" hasil perkalian " + hasil);
            return hasil;
        }

        public int pembagian()
        {
            hasil = Cbil1 / Cbil2;
            Console.WriteLine(" hasil pembagian " + hasil);
            return hasil;
        }

        public void inputan()
        {
            Console.Write(" input bilangan 1 = ");
            bil1 = Console.ReadLine();
            Cbil1 = Convert.ToInt16(bil1);

            Console.Write(" input bilangan 2 = ");
            bil2 = Console.ReadLine();
            Cbil2 = Convert.ToInt16(bil2);

            Console.Write(" Operator aritmatika (+, -, *, /) ");
            Console.Write("\n Piih Operator = ");
            operat = Console.ReadLine();
        }
    }
}
