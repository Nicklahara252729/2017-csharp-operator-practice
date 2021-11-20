using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan hwn = new Hewan();
            Harimau hrm = new Harimau();
            Elang eagle = new Elang();

            //attrib
            hwn.nama = " kutu ";
            hwn.kekuatan = " gigitan ";
            hwn.jumlahkaki = 6;

            hrm.nama = " harimau ";
            hrm.kekuatan = " kaki ";
            hrm.jumlahkaki = 4;

            eagle.nama = " elang jawa ";
            eagle.kekuatan = " sayap ";
            eagle.jumlahkaki = 2;

            //display
            Console.WriteLine(" =================================================");
            Console.WriteLine("\n Nama " + hwn.nama + " kekuatan " + hwn.kekuatan);
            Console.WriteLine(" Nama  " + hrm.nama + " kekuatan " + hrm.kekuatan);
            Console.WriteLine(" Nama  " + eagle.nama + " kekuatan " + eagle.kekuatan);

            //pengaksesan method
            Console.WriteLine("\n =================================================");
            hwn.memangsa();

            hrm.memangsa();
            hrm.berlari();

            eagle.memangsa();
            eagle.terbang();

            Console.Read();
        }
    }
}
