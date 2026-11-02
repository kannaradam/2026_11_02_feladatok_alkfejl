using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace konyvapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> konyvek = File.ReadAllLines("konyvek.csv").Skip(1).ToList();

            int darab = (from s in konyvek select s).Count();
            Console.WriteLine("5. feladat: A nyilvántartott könyvek száma: {0}", darab);

            double atlagAr = (from s in konyvek let darabok = s.Split(';') select double.Parse(darabok[5])).Average();
            Console.WriteLine($"6. feladat: A könyvek átlagára: { atlagAr:F1} Ft");

            var kettoezerElottiek = from s in konyvek
                         let darabok = s.Split(';')
                         let kiadasiEv = int.Parse(darabok[3])
                         where kiadasiEv < 2000
                         select new { Cim = darabok[0], Szerzo = darabok[1], Ev = kiadasiEv };

            Console.WriteLine("7. feladat: 2000 előtt kiadott könyvek:");
            foreach (var k in kettoezerElottiek)
            {
                Console.WriteLine($"\t {k.Cim} ({k.Szerzo}, {k.Ev})");
            }

            var legtobb = konyvek.OrderByDescending(s => int.Parse(s.Split(';')[6])).First().Split(';');

            Console.WriteLine($"8. feladat: {legtobb[0]} ({legtobb[6]} db)");

            var mufajok = konyvek.Skip(1).GroupBy(s => s.Split(';')[2]);

            foreach (var m in mufajok)
            {
                Console.WriteLine($"{m.Key}: {m.Count()} db");
            }

            var legtobbOldal = konyvek.OrderByDescending(s => int.Parse(s.Split(';')[4])).First().Split(';');
            Console.WriteLine($"10. feladat: Legtöbb oldalas: {legtobbOldal[0]} ({legtobbOldal[4]} oldal)");

            int dragaDb = konyvek.Count(s => int.Parse(s.Split(';')[5]) > 6000);
            Console.WriteLine($"11. feladat: {dragaDb} db");

            Console.Write("12. feladat - Kérek egy műfajt: ");
            string bekertmufaj = Console.ReadLine();

            var talalatok = konyvek.Where(s => s.Split(';')[2].Equals(bekertmufaj, StringComparison.OrdinalIgnoreCase)).ToList();

            if (talalatok.Any())
                talalatok.ForEach(s => Console.WriteLine($"\t- {s.Split(';')[0]} ({s.Split(';')[1]})"));
            else
                Console.WriteLine("Nincs találat.");
        }
    }
}
