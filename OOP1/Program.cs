using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program objek = new Program();
            objek.Tumbuhan();
            objek.Hewan();
            Console.Read();
        }
        public void Tumbuhan(){
            Console.WriteLine("Bunga");
            Console.WriteLine("Rumput");
            Console.WriteLine("Pohon");

        }

        private void  Hewan(){
            Console.WriteLine("Harimau");
            Console.WriteLine("Gajah");
            Console.WriteLine("Unta");
        }
    }
}
