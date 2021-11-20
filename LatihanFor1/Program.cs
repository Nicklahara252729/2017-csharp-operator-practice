using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int leave;
            int chicken = 10;

            do
            {
                leave = chicken - 1;
                Console.WriteLine("\n Anak ayam turun " + chicken);

                if (leave == 0)
                {
                    Console.WriteLine(" Mati satu tinggal induknya");
                }
                else
                {
                    Console.WriteLine(" Mati satu tinggal " + leave.ToString());
                }
                chicken--;
            }

            while (chicken >= 1);
            Console.Read();
            
        }
    }
}
