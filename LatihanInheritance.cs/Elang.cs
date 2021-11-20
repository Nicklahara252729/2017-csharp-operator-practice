using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance.cs
{
    class Elang:Hewan
    {
        public override void memangsa()
        {
            Console.WriteLine("\n" + this.nama + " memangsa dengan " + this.kekuatan);
        }
        public void terbang()
        {
            Console.WriteLine(this.nama + " terbang menggunakan " + this.kekuatan);
        }
    }
}
