using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace parkapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> parkok = File.ReadAllLines("parkok.csv").Skip(1).ToList();
            Console.WriteLine($"5. feladat: Nemzeti parkok száma: {parkok.Count}");

            double atlagBelepo = parkok.Average(s => double.Parse(s.Split(';')[4]));
            Console.WriteLine($"6. feladat: Átlagos belépőár: {atlagBelepo:F1} Ft");

            Console.WriteLine("7. feladat: 1990 előtt alapított nemzeti parkok:");
            parkok.Where(s => int.Parse(s.Split(';')[2]) < 1990).ToList().ForEach(s => Console.WriteLine($"\t {s.Split(';')[0]} ({s.Split(';')[1]}, {s.Split(';')[2]})"));

            var legtobbLatogato = parkok.OrderByDescending(s => int.Parse(s.Split(';')[5])).First().Split(';');
            Console.WriteLine($"8. feladat: Legtöbb látogató: {legtobbLatogato[0]} ({legtobbLatogato[5]} fő)");

            Console.WriteLine("9. feladat: Nemzeti parkok száma országonként:");
            foreach (var o in parkok.GroupBy(s => s.Split(';')[1]))
            {
                Console.WriteLine($"\t {o.Key}: {o.Count()} db");
            }
            var legnagyobbTerulet = parkok.OrderByDescending(s => int.Parse(s.Split(';')[3])).First().Split(';');
            Console.WriteLine($"10. feladat: Legnagyobb területű park: {legnagyobbTerulet[0]} ({legnagyobbTerulet[3]} km²)");

            int dragaParkDb = parkok.Count(s => int.Parse(s.Split(';')[4]) > 3000);
            Console.WriteLine($"11. feladat: 3000 Ft-nál drágább parkok száma: {dragaParkDb} db");

            Console.Write("12. feladat - Adjon meg egy országnevet: ");
            string keresettOrszag = Console.ReadLine();

            var talalatok = parkok.Where(s => s.Split(';')[1].Equals(keresettOrszag, StringComparison.OrdinalIgnoreCase)).ToList();

            if (talalatok.Any())
            {
                Console.WriteLine($"A(z) {keresettOrszag} országban található nemzeti parkok:");
                talalatok.ForEach(s => Console.WriteLine($"\t {s.Split(';')[0]} ({s.Split(';')[3]} km²)"));
            }
            else
            {
                Console.WriteLine("Nincs ilyen park");
            }
        }
    }
}
