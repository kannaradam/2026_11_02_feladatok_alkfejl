using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace muzeumapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> muzeumok = File.ReadAllLines("muzeumok.csv").Skip(1).ToList();
            Console.WriteLine($"5. feladat: Múzeumok száma: {muzeumok.Count}");

            double atlagBelepo = muzeumok.Average(s => double.Parse(s.Split(';')[4]));
            Console.WriteLine($"6. feladat: Átlagos belépőár: {atlagBelepo:F1} Ft");

            Console.WriteLine("7. feladat: 1950 előtt alapított múzeumok:");
            muzeumok.Where(s => int.Parse(s.Split(';')[3]) < 1950).ToList().ForEach(s => Console.WriteLine($"\t {s.Split(';')[0]} ({s.Split(';')[1]}, {s.Split(';')[3]})"));

            var legtobbLatogato = muzeumok.OrderByDescending(s => int.Parse(s.Split(';')[5])).First().Split(';');
            Console.WriteLine($"8. feladat: Legtöbb látogató: {legtobbLatogato[0]} ({legtobbLatogato[5]} fő)");

            Console.WriteLine("9. feladat: Múzeumok száma országonként:");
            foreach (var o in muzeumok.GroupBy(s => s.Split(';')[2]))
            {
                Console.WriteLine($"\t {o.Key}: {o.Count()} db");
            }
            var legtobbTargy = muzeumok.OrderByDescending(s => int.Parse(s.Split(';')[6])).First().Split(';');
            Console.WriteLine($"10. feladat: Legtöbb kiállított tárgyú múzeum: {legtobbTargy[0]} ({legtobbTargy[6]} db)");

            int dragaMuzeumDb = muzeumok.Count(s => int.Parse(s.Split(';')[4]) > 4000);
            Console.WriteLine($"11. feladat: 4000 Ft-nál drágább múzeumok száma: {dragaMuzeumDb} db");

            Console.Write("12. feladat - Adjon meg egy várost: ");
            string keresettVaros = Console.ReadLine();

            var talalatok = muzeumok.Where(s => s.Split(';')[1].Equals(keresettVaros, StringComparison.OrdinalIgnoreCase)).ToList();

            if (talalatok.Any())
            {
                Console.WriteLine($"A(z) {keresettVaros} városban található múzeumok:");
                talalatok.ForEach(s => Console.WriteLine($"\t {s.Split(';')[0]} ({s.Split(';')[4]} Ft)"));
            }
            else
            {
                Console.WriteLine("Nincs találat a megadott városra!");
            }
        }
    }
}
