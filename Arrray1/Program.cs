using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrray1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int[] arrayA = new int[5] { 21, 43, 45, 50, 32 };
            Console.WriteLine("Array ke - 0 : {0}", arrayA[0]);
            Console.WriteLine("Array ke - 1 : {0}", arrayA[1]);
            Console.WriteLine("Array ke - 2 : {0}", arrayA[2]);
            Console.WriteLine("Array ke - 3 : {0}", arrayA[3]);
            Console.WriteLine("Array ke - 4 : {0}", arrayA[4]);
             
            string[] arrayB = new string[5] { "saya", "kamu", "dia", "mereka", "kalian" };
            Console.WriteLine("Array ke - 0 : {0}", arrayB[0]);
            Console.WriteLine("Array ke - 1 : {0}", arrayB[1]);
            Console.WriteLine("Array ke - 2 : {0}", arrayB[2]);
            Console.WriteLine("Array ke - 3 : {0}", arrayB[3]);
            Console.WriteLine("Array ke - 4 : {0}", arrayB[4]);*/

            int[] arrayA = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("nilai array A ke - {0} : ", i);
                arrayA[i] = Convert.ToInt16(Console.ReadLine());
                
            }
            Console.WriteLine("data array yang diinput : ");
            for (int i = 0; i <= 4; i++)
            {

                Console.Write(arrayA[i]+" ");
            }
                Console.Read();
        }
    }
}
