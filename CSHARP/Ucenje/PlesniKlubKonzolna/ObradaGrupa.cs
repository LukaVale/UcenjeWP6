using Ucenje.E20KonzolnaAplikacija;
using Ucenje.PlesniKlubKonzolna.Model;

namespace Ucenje.PlesniKlubKonzolna
{
    internal class ObradaGrupa
    {
        public List<Grupa> Grupe {  get; set; }
        private Izbornik Izbornik;

        public ObradaGrupa() 
        {
            Grupe = new List<Grupa>();
            if(Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }
        private void UcitajTestnePodatke()
        {
            Grupe.Add(new() { Naziv = "Početni Tečaj 1"} );
            Grupe.Add(new() { Naziv = "Početni Tečaj 2" });
            Grupe.Add(new() { Naziv = "Početni Tečaj 3" });
        }
        public ObradaGrupa(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s grupama");
            Console.WriteLine("1. Pregled svih grupa");
            Console.WriteLine("2. Unos nove grupe");
            Console.WriteLine("3. Promjena podataka postojeće grupe");
            Console.WriteLine("4. Brisanje grupe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }
        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziGrupe();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNoveGrupe();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeGrupe();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiGrupu();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiGrupu()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za brisanje", 1, Grupe.Count) - 1
                ];
            if (Pomocno.UcitajBool("Sigurno obrisati " + g.Naziv + "? (DA/NE)", "da"))
            {
                Grupe.Remove(g);
            }
        }
        private void PromjeniPodatkeGrupe()
        {
            PrikaziGrupe();
            var g = Grupe[
                Pomocno.UcitajRasponBroja("Odaberi redni broj grupe za promjenu", 1, Grupe.Count) - 1
                ];
            // copy paste s linije 102 - izvući u metodu
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            //smjer
            Izbornik.ObradaVrstaPlesa.PrikaziPlesove();

            g.VrstaPlesa = Izbornik.ObradaVrstaPlesa.Plesovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj smjera", 1, Izbornik.ObradaVrstaPlesa.Plesovi.Count) - 1];

            g.Voditelj = Izbornik.ObradaVoditelj.Voditelji[
                Pomocno.UcitajRasponBroja("Odaberi redni broj voditelja grupe", 1, Izbornik.ObradaVoditelj.Voditelji.Count) - 1];
            g.VelicinaGrupe = Pomocno.UcitajRasponBroja("Unesi veličinu grupe", 1, 30);

            // polaznici
            g.Polaznici = UcitajPolaznike((int)g.VelicinaGrupe);
        }

        private void PrikaziGrupe()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Grupe u plesnom klubu");
            int rb = 0, rbp;
            foreach (var g in Grupe)
            {
                Console.WriteLine(++rb + ". " + g.Naziv + g.VrstaPlesa?.Naziv + g.Voditelj?.Ime + "), " + g.Polaznici?.Count + " polaznika"); // prepisati metodu toString
                rbp = 0;
                g.Polaznici.Sort();
                foreach (var p in g.Polaznici)
                {
                    Console.WriteLine("\t" + ++rbp + ". " + p.Ime + " " + p.Prezime);
                }
            }
            Console.WriteLine("****************************");
        }

        private void UnosNoveGrupe()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o grupi");

            Grupa g = new Grupa();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru grupe", 1, int.MaxValue);
            g.Naziv = Pomocno.UcitajString("Unesi naziv grupe", 50, true);
            //smjer
            Izbornik.ObradaVrstaPlesa.PrikaziPlesove();

            g.VrstaPlesa = Izbornik.ObradaVrstaPlesa.Plesovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj vrste plesa", 1, Izbornik.ObradaVrstaPlesa.Plesovi.Count) - 1];

            g.Voditelj = Izbornik.ObradaVoditelj.Voditelji[
                Pomocno.UcitajRasponBroja("Odaberi redni broj voditelja za ovu grupu", 1, Izbornik.ObradaVoditelj.Voditelji.Count) - 1];
            g.VelicinaGrupe = Pomocno.UcitajRasponBroja("Unesi veličinu grupe", 1, 30);

            // polaznici
            g.Polaznici = UcitajPolaznike((int)g.VelicinaGrupe);

            Grupe.Add(g);
        }

        private List<Polaznik> UcitajPolaznike(int maksimalnoPolaznika)
        {
            List<Polaznik> lista = new List<Polaznik>();
            while (lista.Count < maksimalnoPolaznika && Pomocno.UcitajBool("Za unos polaznika unesi DA", "da"))
            {
                Izbornik.ObradaPolaznik.PrikaziPolaznike();
                Console.WriteLine((Izbornik.ObradaPolaznik.Polaznici.Count + 1) + ". Dodaj novog polaznika");
                var odabranaOpcija = Pomocno.UcitajRasponBroja("Odaberi redni broj polaznika ili zadnji broj za dodavanje novog", 1,
                        Izbornik.ObradaPolaznik.Polaznici.Count + 1);
                if (odabranaOpcija == Izbornik.ObradaPolaznik.Polaznici.Count + 1)
                {
                    // ide novi
                    Izbornik.ObradaPolaznik.UnosNovogPolaznika();
                    lista.Add(Izbornik.ObradaPolaznik.Polaznici.LastOrDefault());
                }
                else
                {
                    lista.Add(Izbornik.ObradaPolaznik.Polaznici[odabranaOpcija - 1]);
                }

            }

            return lista;
        }
    }
}
