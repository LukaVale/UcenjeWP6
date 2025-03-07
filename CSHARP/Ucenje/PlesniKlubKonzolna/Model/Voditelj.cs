namespace Ucenje.PlesniKlubKonzolna.Model
{
    public class Voditelj : Entitet
    {
        public string Ime { get; set; } // max 20 znakova
        public string Prezime { get; set; } // max 35 znakova
        public string Mail { get; set; } // max 40 znakova
        public List<Grupa> Grupe { get; set; } = new List<Grupa>();
        public string Naziv { get; internal set; }
    }

}
