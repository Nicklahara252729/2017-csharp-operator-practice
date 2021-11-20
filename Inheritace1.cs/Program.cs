using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritace1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Virus virus1 = new Virus();
            Trojan trojan1 = new Trojan();
            Worm worm1 = new Worm();

            //pengaksesan atribut
            virus1.nama = "Sality32.exe";
            virus1.kemampuan = "menghapus file exe";
            virus1.size = 32;
            virus1.banyak = 3;

            trojan1.nama = "backdoorwin32.exe";
            trojan1.kemampuan = " shitdown setiap 30 menit ";
            trojan1.size = 14;

            worm1.nama = " brontox.exe ";
            worm1.kemampuan = " sleep setiap 15 menit ";
            worm1.size = 25;

            //display
            Console.WriteLine(" =================================================");
            Console.WriteLine("\n Nama virus : " + virus1.nama + " kapasitas " + virus1.size);
            Console.WriteLine(" Nama trojan : " + trojan1.nama + " kapasitas " + trojan1.size);
            Console.WriteLine(" Nama worm : " + worm1.nama + " kapasitas " + worm1.size);

            //pengaksesan method
            Console.WriteLine("\n =================================================");
            virus1.menyerang();
            virus1.memperbanyakDiri();

            trojan1.menyerang();
            trojan1.menyembunyikanFile();
            trojan1.memblokirCMD();

            worm1.menyerang();
            worm1.menginfeksiregistery();
            worm1.menghapusNTLDR();

            Console.Read();
        }
    }
}
