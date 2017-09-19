using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAG.Model
{
    public class Egzaminatorzy 
    {
        public int EgzaminatorId { get; set; }
        public string EgzaminatorImie { get; set; }
        public string EgzaminatorNazwisko { get; set; }
        public string EgzaminatorCKE { get; set; }
        public string EgzaminatorOsrodek { get; set; }
        public string EgzaminatorMiasto { get; set; }
        public List<Uprawnienia> KwalifikacjeList { get; set; }

        public Egzaminatorzy()
        {
            KwalifikacjeList = new List<Uprawnienia>();
        }

    }
}
