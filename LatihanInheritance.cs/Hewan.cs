using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance.cs
{
    class Hewan
    {
        public string nama, kekuatan;
        public int jumlahkaki;
        public virtual void memangsa()
        {
            Console.WriteLine(this.nama + " memangsa  ikan");
        }

    }
}
