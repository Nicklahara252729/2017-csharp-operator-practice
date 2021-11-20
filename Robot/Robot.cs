using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Robot
    {

        //attribute 
        public string nama;
        public int jumlahkaki;
        public int jumlahtangan;
        public int jumlahrocket;
        public int jumlahsenjata;

        //method
        public void Jalan()
        {
            Console.WriteLine("\n {0} sedang be rjalan", this.nama);
        }
        public void showgun()
        {
            Console.WriteLine("{0} Mengeluarkan senjata", this.nama);
        }
        public void terbang()
        {
            Console.WriteLine(" {0} Mengeluarkan rocket", this.nama);
        }
    }
}
