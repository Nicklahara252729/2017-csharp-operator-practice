using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP1
{
    class Robot
    {
        public string nama;
        public int jumlahkaki , jumlahtangan , senjata , rocket ;

        public void lihatjumlahkaki()
        {
            Console.WriteLine("Robot " +this.nama+" mempunyai jumlah kaki "+this.jumlahkaki);
            
        }

        public void lihattangan()
        {
            Console.WriteLine("Robot " + this.nama + " mempunyai jumlah tangan " + this.jumlahtangan);
        }

        public void lihatsenjata()
        {
            Console.WriteLine("Robot " + this.nama + " mempunyai jumlah senjata " + this.senjata);
        }

        public void terbang()
        {
            Console.WriteLine("Robot " + this.nama + " mempunyai jumlah roket " + this.rocket);
        }
    }
}
