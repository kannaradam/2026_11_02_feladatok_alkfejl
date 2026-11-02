using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvapp
{
    internal class Konyv
    {
        string Cim;
        string Szerzo;
        string Mufaj;
        int KiadasEve;
        int Oldalszam;
        int ArFt;
        int EladottPeldany;
        string Orszag;

        public Konyv(string cim, string szerzo, string mufaj, int kiadasEve, int oldalszam, int arFt, int eladottPeldany, string orszag)
        {
            Cim = cim;
            Szerzo = szerzo;
            Mufaj = mufaj;
            KiadasEve = kiadasEve;
            Oldalszam = oldalszam;
            ArFt = arFt;
            EladottPeldany = eladottPeldany;
            Orszag = orszag;
        }

        public string Cim1 { get => Cim; set => Cim = value; }
        public string Szerzo1 { get => Szerzo; set => Szerzo = value; }
        public string Mufaj1 { get => Mufaj; set => Mufaj = value; }
        public int KiadasEve1 { get => KiadasEve; set => KiadasEve = value; }
        public int Oldalszam1 { get => Oldalszam; set => Oldalszam = value; }
        public int ArFt1 { get => ArFt; set => ArFt = value; }
        public int EladottPeldany1 { get => EladottPeldany; set => EladottPeldany = value; }
        public string Orszag1 { get => Orszag; set => Orszag = value; }
    }
}
