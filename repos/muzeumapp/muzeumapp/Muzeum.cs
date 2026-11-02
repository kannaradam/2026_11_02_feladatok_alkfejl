using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace muzeumapp
{
    internal class Muzeum
    {
        string Nev;
        string    Varos;
        string     Orszag;
        int    AlapitasEve;
        int BelepoFt;
        int EvesLatogato;
        int KiallitottTargyak;
        int TeruletM2;

        public Muzeum(string nev, string varos, string orszag, int alapitasEve, int belepoFt, int evesLatogato, int kiallitottTargyak, int teruletM2)
        {
            Nev = nev;
            Varos = varos;
            Orszag = orszag;
            AlapitasEve = alapitasEve;
            BelepoFt = belepoFt;
            EvesLatogato = evesLatogato;
            KiallitottTargyak = kiallitottTargyak;
            TeruletM2 = teruletM2;
        }

        public string Nev1 { get => Nev; set => Nev = value; }
        public string Varos1 { get => Varos; set => Varos = value; }
        public string Orszag1 { get => Orszag; set => Orszag = value; }
        public int AlapitasEve1 { get => AlapitasEve; set => AlapitasEve = value; }
        public int BelepoFt1 { get => BelepoFt; set => BelepoFt = value; }
        public int EvesLatogato1 { get => EvesLatogato; set => EvesLatogato = value; }
        public int KiallitottTargyak1 { get => KiallitottTargyak; set => KiallitottTargyak = value; }
        public int TeruletM21 { get => TeruletM2; set => TeruletM2 = value; }
    }
}
