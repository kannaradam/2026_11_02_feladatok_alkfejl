using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szallodaapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> szallodak = File.ReadAllLines("szallodak.csv").Skip(1).ToList();
            Console.WriteLine($"5. feladat: Szállodák száma: {szallodak.Count}");

            double atlagAr = szallodak.Average(s => double.Parse(s.Split(';')[5]));
            Console.WriteLine($"6. feladat: Átlagos szobaár: {atlagAr:F1} Ft");

            Console.WriteLine("7. feladat: 2000 előtt megnyitott szállodák:");
            szallodak.Where(s => int.Parse(s.Split(';')[3]) < 2000).ToList().ForEach(s => Console.WriteLine($"\t {s.Split(';')[0]} ({s.Split(';')[1]}, {s.Split(';')[3]})"));

            var legtobbVendeg = szallodak.OrderByDescending(s => int.Parse(s.Split(';')[7])).First().Split(';');
            Console.WriteLine($"8. feladat: Legtöbb vendéget fogadó szálloda: {legtobbVendeg[0]} ({legtobbVendeg[7]} fő)");

            Console.WriteLine("9. feladat: Szállodák száma városonként:");
            foreach (var v in szallodak.GroupBy(s => s.Split(';')[1]))
            {
                Console.WriteLine($"\t- {v.Key}: {v.Count()} db");
            }

            var legtobbSzoba = szallodak.OrderByDescending(s => int.Parse(s.Split(';')[6])).First().Split(';');
            Console.WriteLine($"10. feladat: Legtöbb szobás szálloda: {legtobbSzoba[0]} ({legtobbSzoba[6]} szoba)");

            int dragaSzallodaDb = szallodak.Count(s => int.Parse(s.Split(';')[5]) > 50000);
            Console.WriteLine($"11. feladat: 50 000 Ft-nál drágább szobájú szállodák száma: {dragaSzallodaDb} db");

            Console.Write("12. feladat - Adjon meg egy városnevet: ");
            string keresettVaros = Console.ReadLine();

            var talalatok = szallodak.Where(s => s.Split(';')[1].Equals(keresettVaros, StringComparison.OrdinalIgnoreCase)).ToList();

            if (talalatok.Any())
            {
                Console.WriteLine($"A(z) {keresettVaros} városban található szállodák:");
                talalatok.ForEach(s => Console.WriteLine($"\t- {s.Split(';')[0]} ({s.Split(';')[4]} csillag, {s.Split(';')[5]} Ft)"));
            }
            else
            {
                Console.WriteLine("Nincs találat a megadott városra!");
            }
        }
    }
}
