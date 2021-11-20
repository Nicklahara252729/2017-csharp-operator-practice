using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritace1.cs
{
    class Trojan:Virus
    {
        public override void menyerang()
        {
            Console.WriteLine("\n menyerang dengan " + this.nama, this.kemampuan);
        }
        public void menyembunyikanFile()
        {
            Console.WriteLine(" menyembunyikan file " + this.nama);
        }
        public void memblokirCMD()
        {
            Console.WriteLine(" memblokir CMD " + this.nama);
        }
    }
}
