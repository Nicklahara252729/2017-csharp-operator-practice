using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot();

            robot1.nama = "Hercules";
            robot1.jumlahkaki = 2;
            robot1.jumlahtangan = 2;
            robot1.jumlahsenjata = 8;
            robot1.jumlahrocket = 2;

            Console.WriteLine("\n Nama Robot adalah {0}", robot1.nama);
        }
    }
}
