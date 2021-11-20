using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input banyak element array = ");
            int element = Convert.ToInt32(Console.ReadLine());

            int[] arrayA = new int[element] ;
           

            for (int a = 0; a < element; a++)
            {
                Console.Write("input element ke - "+ a +" = ");
                arrayA[a] = Convert.ToInt32(Console.ReadLine());
            }

            int tampung = arrayA[0];
            int tampung1 = arrayA[0];
            
                for (int i = 0; i < element; i++)
                {
                    if (arrayA[i] < tampung)
                        tampung = arrayA[i];
                }
            Console.WriteLine("nilai minimum = {0}", tampung);
            for (int i = 0; i < element; i++)
            {
                if (arrayA[i] > tampung)
                    tampung = arrayA[i];
            }
            Console.WriteLine("nilai maximum = {0}", tampung);
            Console.Read();
        }
    }
}
