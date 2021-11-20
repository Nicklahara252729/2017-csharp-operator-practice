using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConsole
{
    class Program
    {
        public static double numb1, numb2, hasil;
        public static string act, pergike;
        static void Main(string[] args)
        {
            Program kalku = new Program();
            ke:
            kalku.operat();
            
            if (act == "+")
            {
                Console.WriteLine(" ----------------------------------------- ");
                kalku.tmbh();
            }
            else if (act == "-")
            {
                Console.WriteLine(" ----------------------------------------- ");
                kalku.kurang();
            }
            else if (act == "/")
            {
                Console.WriteLine(" ----------------------------------------- ");
                kalku.bagi();
            }
            else if(act == "*")
            {
                Console.WriteLine(" ----------------------------------------- ");
                kalku.kali();
            }
            else
            {
                Console.WriteLine(" ERROR ");
            }
            Console.WriteLine(" ========================================= ");
            Console.Write(" DO IT AGAIN ? (Y/N) : ");
            pergike = Console.ReadLine();

            if (pergike == "Y" || pergike == "y")
            {
                Console.Clear();
                goto ke;
            }
            else
            {
                Environment.Exit(0);
            }
            Console.Read(); 
        }

        public void operat()
        {
            Console.WriteLine(" ========================================= ");
            Console.WriteLine("             KALKULATOR SEDERHANA          ");
            Console.WriteLine(" ========================================= ");
            Console.Write(" Input bilangan 1          : ");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Pilih Operator ( + * / -) : ");
            act = Console.ReadLine();
            Console.Write(" Input bilangan 2          : ");
            numb2 = Convert.ToInt32(Console.ReadLine());
        }

        public double tmbh()
        {
            hasil = numb1 + numb2;
            Console.WriteLine(" Hasil                     : " + hasil);
            return hasil;
        }

        public double kurang()
        {
            hasil = numb1 - numb2;
            Console.WriteLine(" Hasil                     : " + hasil);
            return hasil;
        }

        public double bagi()
        {
            hasil = numb1 / numb2;
            Console.WriteLine(" Hasil                     : " + hasil);
            return hasil;
        }

        public double kali()
        {
            hasil = numb1 * numb2;
            Console.WriteLine(" Hasil                     : " + hasil);
            return hasil;
        }
    }
}
