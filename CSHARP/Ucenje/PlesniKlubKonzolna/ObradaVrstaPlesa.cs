using Ucenje.E20KonzolnaAplikacija;
using Ucenje.PlesniKlubKonzolna.Model;
namespace Ucenje.PlesniKlubKonzolna
{
    internal class ObradaVrstaPlesa
    {

        public List<Voditelj> Plesovi { get; set; }

        public ObradaVrstaPlesa()
        {
            Plesovi = new List<Voditelj>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Plesovi.Add(new() { Naziv = "Engleski Valcer" });
            Plesovi.Add(new() { Naziv = "Bečki Valcer" });
            Plesovi.Add(new() { Naziv = "Tango" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s vrstama plesa");
            Console.WriteLine("1. Pregled svih vrsta plesa");
            Console.WriteLine("2. Pregled detalja pojedine vrste plesa");
            Console.WriteLine("3. Unos nove vrste plesa");
            Console.WriteLine("4. Promjena podataka postojeće vrste plesa");
            Console.WriteLine("5. Obriši vrstu plesa");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 6))
            {
                case 1:
                    PrikaziPlesove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledDetaljaPojedinogPlesa();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogPlesa();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjeniPostojeciPles();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiPostojeciPles();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        private void PregledDetaljaPojedinogPlesa()
        {
            PrikaziPlesove();
            var s = Plesovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj smjera za detalje", 1, Plesovi.Count) - 1
                ];
            Console.WriteLine("--------------------");
            Console.WriteLine("Detalji plesa:");
            Console.WriteLine("Šifra: " + s.Sifra);
            Console.WriteLine("Naziv: " + s.Naziv);
            Console.WriteLine("--------------------");
        }

        private void ObrisiPostojeciPles()
        {
            PrikaziPlesove();
            var odabrani = Plesovi[Pomocno.UcitajRasponBroja("Odaberi redni broj vrste plesa za Brisanje",
                1, Plesovi.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Naziv + "? (DA/NE)", "da"))
            {
                Plesovi.Remove(odabrani);
            }
        }

        private void PromjeniPostojeciPles()
        {
            PrikaziPlesove();
            var odabrani = Plesovi[Pomocno.UcitajRasponBroja("Odaberi redni broj vrste plesa za promjenu",
                1, Plesovi.Count) - 1];

            if (Pomocno.UcitajRasponBroja("1. Mjenjaš sve\n2. Pojedinačna promjena", 1, 2) == 1)
            {
                odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera  (ne smije biti manje od 1, ali ni veće od 10000)", 1, 10000);
                odabrani.Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50, true);

            }
            else
            {
                // poziv API-u da se javi tko ovo koristi
                switch (Pomocno.UcitajRasponBroja("1. Šifra\n2. Naziv\n",  1, 2))
                {
                    case 1:
                        odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera", 1, int.MaxValue);
                        break;
                    case 2:
                        odabrani.Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50, true);
                        break;
                        // ... ostali

                }
            }
        }

        public void PrikaziPlesove()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Vrste plesova u plesnom klubu");
            int rb = 0;
            foreach (var s in Plesovi)
            {
                Console.WriteLine(++rb + ". " + s.Naziv);
            }
            Console.WriteLine("****************************");
        }

        private void UnosNovogPlesa()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o vrsi plesa");
            Plesovi.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50, true)
            });
        }
    }
}
