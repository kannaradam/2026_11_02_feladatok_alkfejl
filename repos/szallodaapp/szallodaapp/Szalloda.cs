using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szallodaapp
{
    internal class Szalloda
    {
        string Nev;
        string Varos;
        string Orszag;
        int NyitasEve;
        int Csillagok;
        int SzobaArFt;
        int SzobakSzama;
        int EvesVendegek;

        public Szalloda(string nev, string varos, string orszag, int nyitasEve, int csillagok, int szobaArFt, int szobakSzama, int evesVendegek)
        {
            Nev = nev;
            Varos = varos;
            Orszag = orszag;
            NyitasEve = nyitasEve;
            Csillagok = csillagok;
            SzobaArFt = szobaArFt;
            SzobakSzama = szobakSzama;
            EvesVendegek = evesVendegek;
        }

        public string Nev1 { get => Nev; set => Nev = value; }
        public string Varos1 { get => Varos; set => Varos = value; }
        public string Orszag1 { get => Orszag; set => Orszag = value; }
        public int NyitasEve1 { get => NyitasEve; set => NyitasEve = value; }
        public int Csillagok1 { get => Csillagok; set => Csillagok = value; }
        public int SzobaArFt1 { get => SzobaArFt; set => SzobaArFt = value; }
        public int SzobakSzama1 { get => SzobakSzama; set => SzobakSzama = value; }
        public int EvesVendegek1 { get => EvesVendegek; set => EvesVendegek = value; }
    }
}
