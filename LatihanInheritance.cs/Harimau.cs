using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance.cs
{
    class Harimau:Hewan
    {
        public override void memangsa()
        {
            Console.WriteLine("\n" + this.nama + " memangsa dengan cara : " + this.kekuatan);
        }

        public void berlari()
        {
            Console.WriteLine(this.nama + " berlari menggunakan : " + this.kekuatan);
        }
    }
}
