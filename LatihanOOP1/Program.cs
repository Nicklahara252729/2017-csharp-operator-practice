using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot rbt = new Robot();
            rbt.nama = "Baymax";
            rbt.jumlahkaki = 2;
            rbt.jumlahtangan = 2;
            rbt.senjata = 5;
            rbt.rocket = 5;

            rbt.lihatjumlahkaki();
            rbt.lihattangan();
            rbt.lihatsenjata();
            rbt.terbang();

            Console.Read();
        }
    }
}
