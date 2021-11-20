using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kondisi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string nim, nama,  ntugas, nuts, nuas;
            double nakhir,  n_tugas, n_uts, n_uas;
            Console.Write("\n nim : ");
            nim = Console.ReadLine();
            Console.Write(" nama : ");
            nama = Console.ReadLine();
           // Console.Write(" nilai absen : ");
           // nabsen = Console.ReadLine();
            Console.Write(" nilai tugas : ");
            ntugas = Console.ReadLine();
            Console.Write(" nilai uts : ");
            nuts = Console.ReadLine();
            Console.Write(" nilai uas : ");
            nuas = Console.ReadLine();
           // n_absen = Convert.ToDouble(nabsen);
            n_tugas = Convert.ToDouble(ntugas);
            n_uts = Convert.ToDouble(nuts);
            n_uas = Convert.ToDouble(nuts);
            nakhir = (n_absen * 10 / 100) +  (n_tugas * 20 / 100) + (n_uts * 30 / 100) + (n_uas * 40 / 100);
            Console.WriteLine(" nilai akhir : {0}", nakhir);
            if (nakhir >= 80 && nakhir <=100)
            {
                Console.WriteLine(" Grade : A");
            }
            else if (nakhir >= 70 && nakhir <=79)
            {
                Console.WriteLine(" Grade : B");
            }
            else if (nakhir >= 50 && nakhir <=69)
            {
                Console.WriteLine(" Grade : C");
            }
            else
            {
                Console.WriteLine(" Grade : E");
            }
            Console.Read();*/

           string JKelamin,Tinggi,lagi;
            int ConvTinggi;
            x:
            Console.WriteLine(" Jenis Kelamin");
            Console.WriteLine(" ==================");
            Console.WriteLine(" 1. Pria");
            Console.WriteLine(" 2. Wanita");
            Console.WriteLine(" ==================");
            Console.Write(" Input Pilihan Anda (1/2) : ");
            JKelamin = Console.ReadLine();
            Console.Write(" Input Tinggi Badan Anda : ");
            Tinggi = Console.ReadLine();
            ConvTinggi = Convert.ToInt16(Tinggi);
            if (JKelamin == "1") 
            {
                if (ConvTinggi >= 170)
                {
                    Console.WriteLine(" anda lulus");
                }
                else
                {
                    Console.WriteLine(" anda tidak lulus");
                }

            }
            else if (JKelamin == "2")
            {
                if (ConvTinggi >= 160)
                {
                    Console.WriteLine(" anda lulus");
                }
                else
                {
                    Console.WriteLine(" anda tidak lulus");
                }
            }
            else
            { Console.WriteLine(" 404 Jenis Kelamin Tidak Ditemukan "); }
            Console.Write(" Mau coba lagi (y/n) : ");
            lagi = Console.ReadLine();
            if (lagi == "y" || lagi == "Y")
            {
                Console.Clear();
                goto x;
            }
            Console.Read();

 
        }
    }
}
