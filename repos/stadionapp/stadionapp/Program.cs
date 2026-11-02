using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stadionapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stadionok = File.ReadAllLines("stadionok.csv").Skip(1).ToList();
            Console.WriteLine($"5. feladat: Stadionok száma: {stadionok.Count}");

            double atlagBeljegy = stadionok.Average(s => double.Parse(s.Split(';')[5]));
            Console.WriteLine($"6. feladat: Átlagos belépőjegyár: {atlagBeljegy:F1} Ft");

            Console.WriteLine("7. feladat: 1980 előtt épült stadionok:");
            stadionok.Where(s => int.Parse(s.Split(';')[3]) < 1980).ToList().ForEach(s => Console.WriteLine($"\t- {s.Split(';')[0]} ({s.Split(';')[1]}, {s.Split(';')[3]})"));

            var legtobbFerohely = stadionok.OrderByDescending(s => int.Parse(s.Split(';')[4])).First().Split(';');
            Console.WriteLine($"8. feladat: Legtöbb férőhelyes stadion: {legtobbFerohely[0]} ({legtobbFerohely[4]} fő)");

            Console.WriteLine("9. feladat: Stadionok száma országonként:");
            foreach (var o in stadionok.GroupBy(s => s.Split(';')[2]))
            {
                Console.WriteLine($"\t- {o.Key}: {o.Count()} db");
            }
            var legtobbRendezveny = stadionok.OrderByDescending(s => int.Parse(s.Split(';')[6])).First().Split(';');
            Console.WriteLine($"10. feladat: Legtöbb rendezvényt tartó stadion: {legtobbRendezveny[0]} ({legtobbRendezveny[6]} db)");

            int dragaStadionDb = stadionok.Count(s => int.Parse(s.Split(';')[5]) > 7000);
            Console.WriteLine($"11. feladat: 7000 Ft-nál drágább belépőjegyű stadionok száma: {dragaStadionDb} db");

            Console.Write("12. feladat - Adjon meg egy várost: ");
            string keresettVaros = Console.ReadLine();

            var talalatok = stadionok.Where(s => s.Split(';')[1].Equals(keresettVaros, StringComparison.OrdinalIgnoreCase)).ToList();

            if (talalatok.Any())
            {
                Console.WriteLine($"A(z) {keresettVaros} városban található stadionok:");
                talalatok.ForEach(s => Console.WriteLine($"\t {s.Split(';')[0]} ({s.Split(';')[4]} férőhely)"));
            }
            else
            {
                Console.WriteLine("Nincs találat a megadott városra!");
            }
        }
    }
}
