using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nimi");
            string vastaus1 = Console.ReadLine();
            viimeinenkirjain(vastaus1);
            Console.ReadLine();
        }
        static void positiivinen(int luku1)
        { 
            if (luku1 < 0) 
            {
                Console.WriteLine(luku1 - (luku1 * 2));
            }
            else
            {
                Console.WriteLine(luku1);
            }
        }

        static void viimeinenkirjain(string input1)
        {
            int pituus = input1.Length;

            Console.WriteLine("Viimeinen kirjain on: " + input1[pituus -1]);

        }

    }
}
