using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerhitunganMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[3, 3] { {2,0,1 }, {3,4,1 }, {2,5,10 } };
            int[,] matrixB = new int[3, 3] { { 1,3,5 }, { 7,9,10 }, { 2,4,6  } };
            int[,] Hasil = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Hasil[i, k] = matrixA[i, k] + matrixB[i, k];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    //Console.WriteLine("baris ke " + i + " kolom ke " + k + " adalah " + Hasil[i, k]);
                    Console.Write(" "+Hasil[i,k]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
