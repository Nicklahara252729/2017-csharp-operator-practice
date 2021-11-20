using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritace1.cs
{
    class Virus
    {
        public string nama, kemampuan;
        public int size, banyak;

        public virtual void menyerang()
        {
            Console.WriteLine("\n Menyerang dengan " + this.kemampuan);
        }

        public void memperbanyakDiri()
        {
            Console.WriteLine(" Memperanyak file hingga " + this.nama, this.banyak * 5);
        }
    }
}
