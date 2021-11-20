using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerulanganForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Stringarray = {"one","two","three"};
            foreach(string element in Stringarray){
                Console.WriteLine(element + " ");
            }
            Console.Read();
        }
    }
}
