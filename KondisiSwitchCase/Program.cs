using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KondisiSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string pilihan;
            double hrg, total, ConvJumlah, disc, TotalAkhir;
            Console.WriteLine(" Menu Makanan");
            Console.WriteLine(" Nama Makanan ||");
            Console.WriteLine(" 1. Nasi Goreng    Rp.17,000");
            Console.WriteLine(" 2. Sate           Rp.14,000");
            Console.Write(" Input menu pilihan (1/2) : ");
            pilihan = Console.ReadLine();
            Console.Write(" Input jumlah pesanan : ");
            string Jumlah = Console.ReadLine();
            ConvJumlah = Convert.ToDouble(Jumlah);

            switch (pilihan)
            {
                case "1":
                    if (ConvJumlah > 5)
                    {
                        hrg = 17000;
                        total = hrg * ConvJumlah;
                        disc = total * 0.20;
                        TotalAkhir = total - disc;
                        Console.WriteLine(" Anda Mendapatkan Diskon 20% ");
                        Console.WriteLine(" Anda Memesan Nasi Goreng");
                        Console.WriteLine(" Harga Normal = {0} ", total);
                        Console.WriteLine(" Harga Diskon = {0} ", TotalAkhir);
                    }
                    else
                    {
                        hrg = 17000;
                        total = hrg * ConvJumlah;
                        Console.WriteLine(" Anda Memesan Nasi Goreng");
                        Console.WriteLine(" Harga yang anda bayar = {0} ", total);
                    }
                break;

                case "2":
                if (ConvJumlah > 5)
                {
                    hrg = 14000;
                    total = hrg * ConvJumlah;
                    disc = total * 0.20;
                    TotalAkhir = total - disc;
                    Console.WriteLine(" Anda Mendapatkan Diskon 20% ");
                    Console.WriteLine(" Anda Memesan Sate");
                    Console.WriteLine(" Harga Normal = {0} ", total);
                    Console.WriteLine(" Harga Diskon = {0} ", TotalAkhir);
                }
                else
                {
                    hrg = 14000;
                    total = hrg * ConvJumlah;
                    Console.WriteLine(" Anda Memesan Sate");
                    Console.WriteLine(" Harga yang anda bayar = {0} ", total);
                }
                break;

                default:
                    Console.WriteLine(" 404 Not Found ");
                break;
            }

            Console.Read();
        }
    }
}
