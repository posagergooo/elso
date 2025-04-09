using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            4.
            Random rnd = new Random();
            int szam1 = rnd.Next(-10, 11);
            int szam2 = rnd.Next(-10, 11);
            Console.WriteLine("A generált számjaid: (" + szam1 + ";" + szam2 + ")");

            if (szam1 == 0)
            {
                Console.WriteLine("Ez az x tengelyen van");
            }
            else
            {
                if (szam2 == 0)
                {
                    Console.WriteLine("Ez az y tengelyen van");
                }
            }

            if (szam1 == 0 && szam2 == 0)
            {
                Console.WriteLine("Ez az origó");
            }
            Console.ReadKey();

            5.

            Random rnd = new Random();
            int szam = rnd.Next(-5, 6);
            Console.WriteLine("A számod: " + szam + "");
            Console.ReadKey();
            if (szam >= 0)
            {
                Console.WriteLine("A számod pozitív");

            }
            else
            {
                Console.WriteLine("A számod negatív");
                Console.WriteLine("A számod abszolút értéke:" + (szam * (-1)));
            }
            Console.ReadKey();
            if (szam % 2 == 0)
            {
                Console.WriteLine("A számod páros");

            }
            else
            {
                Console.WriteLine("A számod páratlan");
            }
            Console.ReadKey();
            if (szam % 3 == 0)
            {
                Console.WriteLine("A számod osztható 3-mal");
            }
            else
            {
                Console.WriteLine("A számod nem osztható 3-mal");
            }

            Console.ReadKey();

            6.
            int szam1;
            int szam2;
            Console.Write("Kérek egy egész számot: ");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérek még egy egész számot: ");
            szam2 = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int szam3 = rnd.Next(szam1, szam2);
            Console.WriteLine(szam3);
            int szam4 = rnd.Next(szam1, szam2);
            Console.WriteLine(szam4);
            int szam5 = rnd.Next(szam1, szam2);
            Console.WriteLine(szam5);
            if (szam3 == szam4 || szam4 == szam5 || szam5 == szam3)
            {
                Console.WriteLine("Van 2 darab egyforma számod!");
            }
            else
            {
                Console.WriteLine("Nincs 2 darab egyforma számod");
            }
            Console.ReadKey();


        }
    }
}
