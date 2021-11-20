using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayA = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("input baris ke " + i + " kolom ke " + j +" = ");
                    arrayA[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
           
            //Console.Write("array ke - 0,1 = " + arrayA[0, 1]);
            //Console.Write("array ke - 2,2 = " + arrayA[2, 2]);

           
           
            for (int o = 0; o < 3; o++)
            {
                for (int p = 0; p < 3; p++)
                {
                    Console.Write(arrayA[o, p]);
                }
                Console.WriteLine();    
            }
                Console.Read();
        }
    }
}
