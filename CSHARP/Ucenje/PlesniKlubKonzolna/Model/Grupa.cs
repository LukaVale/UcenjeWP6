namespace Ucenje.PlesniKlubKonzolna.Model
{
    public class Grupa : Entitet
    {
        public string Naziv { get; set; } // max 30 znakova
        public string? Opis { get; set; } // tekstualni opis, može biti null
        public int VrstaPlesaId { get; set; }
        public Voditelj VrstaPlesa { get; set; }
        public int? VelicinaGrupe { get; set; }
        public int VoditeljId { get; set; }
        public Voditelj Voditelj { get; set; }
        public List<Polaznik> Polaznici { get; set; } = new List<Polaznik>();
    }
}
