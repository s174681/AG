using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAG.Model
{
    public class Egzaminy
    {
        public int EgzaminId { get; set; }
        public string OsrodekKod { get; set; }
        public string OsrodekNazwa { get; set; }
        public string OsrodekMiejscowosc { get; set; }
        public string KwalifikacjaKod { get; set; }
        public string KwalifikacjaNazwa { get; set; }
        public int CzasTrwania { get; set; }
        public int LiczbaEgzaminatorow { get; set; }
        public bool IsPracujeWeekend { get; set; }
        public List<Egzaminatorzy> EgzaminatorzyList { get; set; }
        public string Kryterium { get; set; }

        public Egzaminy()
        {
            EgzaminatorzyList = new List<Egzaminatorzy>();
            IsPracujeWeekend = true;
        }

        //public Egzaminy(List<Egzaminatorzy> egzaminatorzy)
        //{
        //    foreach (Egzaminatorzy item in egzaminatorzy)
        //    {
        //        EgzaminatorzyList.Add((Egzaminatorzy)item.Clone());
        //    }
        //}

        //public Egzaminy GlebokaKopia()
        //{
        //    Egzaminy kopia = new Egzaminy();
        //    kopia.EgzaminId = this.EgzaminId;
        //    kopia.OsrodekKod = this.OsrodekKod;
        //    kopia.OsrodekNazwa = this.OsrodekNazwa;
        //    kopia.OsrodekMiejscowosc = this.OsrodekMiejscowosc;
        //    kopia.KwalifikacjaKod = this.KwalifikacjaKod;
        //    kopia.KwalifikacjaNazwa = this.KwalifikacjaNazwa;
        //    kopia.CzasTrwania = this.CzasTrwania;
        //    kopia.LiczbaEgzaminatorow = this.LiczbaEgzaminatorow;
        //    kopia.IsPracujeWeekend = this.IsPracujeWeekend;
        //    kopia.EgzaminatorzyList = this.EgzaminatorzyList;
        //    kopia.Kryterium = this.Kryterium;
        //    //foreach (Egzaminatorzy item in egzaminator)
        //    //{
        //    //    egzaminator.EgzaminatorId = this.EgzaminatorzyList.ElementAt(item).EgzaminatorId;

        //    //}
        //    //kopia.EgzaminatorzyList.ElementAt().EgzaminatorId = this.EgzaminatorzyList.ElementAt().EgzaminatorId;

        //    return kopia;
        
        //}
    }

}
