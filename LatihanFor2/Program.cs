using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int row=1;
            int row = 1, baris = 1;
            while (baris <= 5)
            {
                int kolom = 1; 
                do
                {
                    Console.Write(row + " ");
                    row = row + 1;
                    kolom++;
                }
                while (kolom <= baris);
                Console.WriteLine(" ");
                baris++;
            }
            Console.Read();
            /*for (int baris = 1; baris <= 5; baris++)
            {
            
                for (int kolom = 1; kolom <= baris; kolom++)
                {

                    Console.Write( row + " ");
                    row = row + 1;
                }
                Console.WriteLine(" ");
            }
            Console.Read();*/
        }
    }
}
