using Ucenje.PlesniKlubKonzolna.Model;

namespace Ucenje.PlesniKlubKonzolna
{
    internal class ObradaVoditelj
    {
        public List<Voditelj> Voditelji { get; set; }

        public ObradaVoditelj()
        {
            Voditelji = new List<Voditelj>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Voditelji.Add(new() { Naziv = "Engleski Valcer" });
            Voditelji.Add(new() { Naziv = "Bečki Valcer" });
            Voditelji.Add(new() { Naziv = "Tango" });
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
                    PrikaziVoditelje();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledDetaljaVoditelja();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogVoditelja();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjeniPostojecegVoditelja();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiPostojecegVoditelja();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        private void PregledDetaljaVoditelja()
        {
            PrikaziVoditelje();
            var s = Voditelji[
                Pomocno.UcitajRasponBroja("Odaberi redni broj voditelja za detalje", 1, Voditelji.Count) - 1
                ];
            Console.WriteLine("--------------------");
            Console.WriteLine("Detalji voditelja:");
            Console.WriteLine("Šifra: " + s.Sifra);
            Console.WriteLine("Naziv: " + s.Naziv);
            Console.WriteLine("--------------------");
        }

        private void ObrisiPostojecegVoditelja()
        {
            PrikaziVoditelje();
            var odabrani = Voditelji[Pomocno.UcitajRasponBroja("Odaberi redni broj voditelja za brisanje",
                1, Voditelji.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Naziv + "? (DA/NE)", "da"))
            {
                Voditelji.Remove(odabrani);
            }
        }

        private void PromjeniPostojecegVoditelja()
        {
            PrikaziVoditelje();
            var odabrani = Voditelji[Pomocno.UcitajRasponBroja("Odaberi redni broj voditelja za promjenu",
                1, Voditelji.Count) - 1];

            if (Pomocno.UcitajRasponBroja("1. Mjenjaš sve\n2. Pojedinačna promjena", 1, 2) == 1)
            {
                odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru voditelja  (ne smije biti manje od 1, ali ni veće od 10000)", 1, 10000);
                odabrani.Naziv = Pomocno.UcitajString("Unesi naziv voditelja", 50, true);

            }
            else
            {
                // poziv API-u da se javi tko ovo koristi
                switch (Pomocno.UcitajRasponBroja("1. Šifra\n2. Naziv\n", 1, 2))
                {
                    case 1:
                        odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru voditelja", 1, int.MaxValue);
                        break;
                    case 2:
                        odabrani.Naziv = Pomocno.UcitajString("Unesi naziv voditelja", 50, true);
                        break;
                        // ... ostali

                }
            }
        }

        public void PrikaziVoditelje()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Voditelji u plesnom klubu");
            int rb = 0;
            foreach (var s in Voditelji)
            {
                Console.WriteLine(++rb + ". " + s.Naziv);
            }
            Console.WriteLine("****************************");
        }

        private void UnosNovogVoditelja()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o voditelju ");
            Voditelji.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru voditelja", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv voditelja", 50, true)
            });
        }
    }
}
