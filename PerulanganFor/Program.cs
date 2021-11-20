using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerulanganFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //MENGGUNAKAN ++
            /*for(int angka = 1; angka <=10; angka++){
                Console.WriteLine("\n Angka Ke - "+angka.ToString());
            }
            Console.Read();*/

            //MENGUNAKAN --

           
            int  total = 1;
            //Console.Write(" Input Batas Nilai = ");
            //nilai = Console.ReadLine();
            //Cnilai = Convert.ToInt16(nilai);
            int angka = 5;
            do
            {
                total = total * angka;
                //total *= angka;
                Console.Write(" {0} *", angka);
                angka--;
            }
            while (angka >= 1);
            Console.Write("\b");
            Console.Write(" = {0} ", total);
            Console.Read();

            /*for (int i=0;i<=10;i++){
                Console.WriteLine("Perulangan");
            }

            Console.Read();*/
        }
    }
}
