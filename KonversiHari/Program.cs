using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonversiHari
{
    class Program
    {
        static void Main(string[] args)
        {
            string hari;
            int ConvHari, HTahun, HBulan, HHari;
            Console.WriteLine("====================");
            Console.WriteLine(" Konversi Hari");
            Console.WriteLine("====================");
            Console.Write(" Input Banyak Hari : ");
            hari = Console.ReadLine();
            ConvHari = Convert.ToInt16(hari);
            HTahun = ConvHari / 365;
            HBulan = ConvHari % 365 /30 ;
            //HHari  = ConvHari % 365 % 30;
            HHari = ConvHari - ((HTahun * 365) + (HBulan * 30));
            /*Console.Write(" {0}", HTahun);
            Console.Write(" Tahun");
            Console.Write(" {0}", HBulan);
            Console.Write(" Bulan");
            Console.Write(" {0}", HHari);
            Console.Write(" Hari");*/
            Console.Write("{0} Tahun {1} Bulan {2} Hari", HTahun, HBulan, HHari);
            Console.Read();
        }
    }
}
