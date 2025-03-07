namespace Ucenje.PlesniKlubKonzolna.Model
{
   public class GrupaPolaznik
    {
        public int GrupaID { get; set; }
        public Grupa Grupa { get; set; }
        public int PolaznikID { get; set; }
        public Polaznik Polaznik { get; set; }
    }

}
