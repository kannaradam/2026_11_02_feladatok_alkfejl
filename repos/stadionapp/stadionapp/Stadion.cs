using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stadionapp
{
    internal class Stadion
    {
        string Nev;
        string Varos;
        string Orszag;
        int EpitesEve;
        int Ferohely;
        int BeljegyFt;
        int EvesRendezvenyek;
        int MagassagM;

        public Stadion(string nev, string varos, string orszag, int epitesEve, int ferohely, int beljegyFt, int evesRendezvenyek, int magassagM)
        {
            Nev = nev;
            Varos = varos;
            Orszag = orszag;
            EpitesEve = epitesEve;
            Ferohely = ferohely;
            BeljegyFt = beljegyFt;
            EvesRendezvenyek = evesRendezvenyek;
            MagassagM = magassagM;
        }

        public string Nev1 { get => Nev; set => Nev = value; }
        public string Varos1 { get => Varos; set => Varos = value; }
        public string Orszag1 { get => Orszag; set => Orszag = value; }
        public int EpitesEve1 { get => EpitesEve; set => EpitesEve = value; }
        public int Ferohely1 { get => Ferohely; set => Ferohely = value; }
        public int BeljegyFt1 { get => BeljegyFt; set => BeljegyFt = value; }
        public int EvesRendezvenyek1 { get => EvesRendezvenyek; set => EvesRendezvenyek = value; }
        public int MagassagM1 { get => MagassagM; set => MagassagM = value; }
    }
}
