using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Siswa objek = new Siswa();
            Mapel mapelobj = new Mapel();
            mapelobj.namaMapel = "Pemrograman";
            mapelobj.namaGuru  = "Novelman";
            Console.WriteLine(objek.nis);
            Console.WriteLine(objek.nama);
            Console.WriteLine(objek.umur);
            objek.pelajaran();
            Console.WriteLine("=============================");
            Console.WriteLine(mapelobj.namaMapel);
            Console.WriteLine(mapelobj.namaGuru);
            Console.Read();
        }
    }
}
