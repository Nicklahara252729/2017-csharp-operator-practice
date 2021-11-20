using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanFor3
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*int baris, kolom;
            for(baris =1; baris<=5; baris++)
            {
                for (kolom =1; kolom <= 5; kolom++ )
                {
                    if ((baris == 1 &&  kolom==1) || (baris == 2 && kolom ==2) || (baris == 3 && kolom ==3) || (baris == 4 && kolom == 4) || (baris == 5 && kolom ==5) ||
                        (baris == 1 && kolom==5) || (baris == 2 && kolom ==4) || (baris == 3 && kolom ==3) || (baris == 4 && kolom == 2) || (baris == 5 && kolom ==1) )
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("");
            }
            Console.Read();*/
            int baris, kolom;
            for (baris = 1; baris <= 5; baris++)
            {
                for (kolom = 5; kolom >=1; kolom--)
                {
                    if (baris == 1 || baris == 5 || (baris == kolom ) )
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
