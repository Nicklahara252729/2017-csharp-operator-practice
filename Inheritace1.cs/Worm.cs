using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritace1.cs
{
    class Worm:Virus
    {
       
        public override void menyerang()
        {
            Console.WriteLine("\n menyerang dengan " + this.nama, this.kemampuan);
        }

        public void menginfeksiregistery()
        {
            Console.WriteLine(" menginfeksi file " + this.nama);
        }

        public void menghapusNTLDR()
        {
            Console.WriteLine(" menghapus NTLDR " + this.nama);
        }
    }
}
