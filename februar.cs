using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PósaGergő_februar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Adjuk meg az éves statisztika alapján, hogy hány napon fagyott!A feladat megoldásához hozz létre egy egész számokból álló 365 elemű tömböt. 
            //  Töltsd fel véletlen - számokkal(ha ügyes vagy arra is ügyelsz, hogy az év adott sorszámú napján mi a jellemző hőmérséklet és annak megfelelő 
            //  számokat generálsz - pl.: télen - 10 és 5 fok között, nyáron 20 és 30 között, stb.).A fagyos napok számlálásakor minden adatot vizsgálj meg!

            Random rnd = new Random();
            int[] napok = new int[365];
            int fok = 0;

            //tél1
            for (int i = 334; i < 365; i++)
            {
                napok[i] = rnd.Next(-10, 5);
            }
            //tél2
            for (int i = 0; i < 59; i++)
            {
                napok[i] = rnd.Next(-10, 5);
            }
            //tavasz
            for (int i = 90; i < 273; i++)
            {
                napok[i] = rnd.Next(-5, 25);
            }
            //ősz
            for (int i = 273; i < 334; i++)
            {
                napok[i] = rnd.Next(-10, 20);
            }

            //nyár
            for (int i = 0; i < napok.Length; i++)
            {
                if (napok[i] < 0)
                {
                    fok++;
                }
            }

            Console.WriteLine("365 napból " + fok + " napon fagyott");
            Console.ReadKey();

            //2.Adjuk meg egy angol szó egy magánhangzóját!Kérj be egy szót a felhasználótól és feladatot ennek segítségével old meg!
            string szo;
            Console.Write("Kérek egy angol szót: ");
            szo = Convert.ToString(Console.ReadLine());
            int db1 = 0;
            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i] == 'a' || szo[i] == 'A' || szo[i] == 'e' || szo[i] == 'E' || szo[i] == 'i' || szo[i] == 'I' || szo[i] == 'o' || szo[i] == 'O' || szo[i] == 'u' || szo[i] == 'U')
                {
                    db1++;
                    Console.WriteLine(szo[i]);
                }
            }

            Console.ReadKey();


            //3.Adjuk meg egy számsorozat olyan elemét, amely nagyobb az előzőnél!A számokat egy egész típusú tömbben tárold el és generáld véletlen!
            //  A tömb elemszámát a felhasználó adja meg!
            int darab;
            Console.Write("Adja meg hány elemből álljon a tömb: ");
            darab = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[darab];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1,21);
            }
            int elotte = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (i > 0)
                {
                    if (tomb[i] > elotte)
                    {
                        Console.WriteLine(elotte + " nagyobb mint az előző szám!");
                    }
                }
                elotte = tomb[i];
            }
            Console.ReadKey();



            //4.Adjuk meg 100 születési hónap alapján, hogy közöttük hányan születtek télen! A tömbben a születési hónapok sorszámát tárold
            //  (generálhatod is).A téli hónapok: december, január és február(12, 1 és 2)
            int tel1 = 0;
            int[] szuletik = new int[100];
            for (int i = 0; i < 100; i++)
            {
                szuletik[i] = rnd.Next(1, 12);
                if (szuletik[i] == 1 || szuletik[i] == 12 || szuletik[i] == 2)
                {
                    tel1++;
                }
            }
            Console.WriteLine(tel1 + " db ember született télen!");
            Console.ReadKey();

            //5.Adjunk meg egy tanulóra egy olyan tárgyat, amiből jeles! A tömbben 1 és 5 közötti egész számokat tárolj, annyit, amennyi különböző tárgyat tanul a diák! 
            //  Megfelel, ha a tantárgy sorszámát adod válaszul. Ha szép megoldást szeretnél, hozz létre egy párhuzamos tömböt, amiben a tantárgyak neve van, így a válasz 
            //  nem egy sorszám, hanem egy tantárgy lesz! A megoldáshoz felhasználhatod az alábbi kódrészletet, amelyben a tömb létrehozása során az elemek értéket is kapnak:
            //string[] tantatgyak = new string[] { "magyar nyelv és irodalom", "angol nyelv", "matematika", "történelem" };

            //6.Egy szóról mondjuk meg, hogy egy hónapnak a neve - e! Tárold el a hónapok nevét egy tömbben(itt is felhasználhatod a fenti példát), erre végezz ellenőrzést!
            string[] honapok = new string[] { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
            Console.WriteLine("Adj meg egy nevet: ");
            string megad = Console.ReadLine();

            for (int i = 0; i < 12; i++)
            {
                if (megad == honapok[i])
                {
                    Console.WriteLine("A megadott szó egy hónapnak a neve");
                    int talalt = 1;
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
