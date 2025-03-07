using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using Ucenje.PlesniKlubKonzolna.Model;

namespace Ucenje.PlesniKlubKonzolna
{
    internal class Izbornik
    {
        public ObradaGrupa ObradaGrupa {  get; set; }
        public ObradaPolaznik ObradaPolaznik { get; set; }
        public ObradaVoditelj ObradaVoditelj { get; set; }
        public ObradaVrstaPlesa ObradaVrstaPlesa { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = true;
            ObradaGrupa = new ObradaGrupa();
            ObradaPolaznik = new ObradaPolaznik();
            ObradaVoditelj = new ObradaVoditelj();
            ObradaVrstaPlesa = new ObradaVrstaPlesa();
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void UcitajPodatke()
        {
            string docPath= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path.Combine(docPath, "plesovi.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "plesovi.json"));
                ObradaVrstaPlesa.Plesovi = JsonConvert.DeserializeObject<List<Voditelj>>(file.ReadToEnd());
                file.Close();

            }
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Grupe");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Vrste plesova");
            Console.WriteLine("4. Voditelji");
            Console.WriteLine("5. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))
            {
                case 1:
                    Console.Clear();
                    ObradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaVrstaPlesa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.Clear();
                    ObradaVoditelj.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");
                    SpremiPodatke();
                    break;
            }
        }
        private void SpremiPodatke()
        {
            if (Pomocno.DEV)
            {
                return;
            }

            string docPath =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "plesovi.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaVrstaPlesa.Plesovi));
            outputFile.Close();
        }
        private void PozdravnaPoruka()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** Plesni klub Console App v 1.0 ***");
            Console.WriteLine("*********************************");
        }
    }
}
