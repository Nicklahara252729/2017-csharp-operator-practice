using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Password yang anda masukkan salah, coba lagi ");
            Console.Write(" Masukkan Password : ");
            string pass = Console.ReadLine();
            switch (pass)
            {
                case"nicks":
                    Console.Clear();
                    Console.WriteLine(" Selamat datang di ruang admin ");
                    Console.WriteLine(" ============================= ");
                break;
                default:
                    Console.Clear();
                    Console.WriteLine(" Anda tidak berhak masuk ke dalam sistem ini ");
                break;
            }
            Console.Read();
        }
    }
}
