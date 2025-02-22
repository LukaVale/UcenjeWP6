using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObject
{
    public class Program
    {
        // 5. Vrsta metode - konstruktor 
        // Konstruktor mora imati isti naziv kao i klasa, a lista parametara može biti različici

        public Program() 
        {
            // Objekt je instanca klase
             
            // Osoba je ime klase
            // osoba je ime objekta - varijabla

            Osoba osoba = new Osoba();

            osoba.Sifra = 1;
            osoba.Ime = "Pero"; //Metode.UcitajString("Unesi ime osobe: ");
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.Ime);

            osoba = new Osoba() 
            { 
                Sifra = 2, 
                Ime = "Karlo", 
                Prezime = "Lik" 
            };
            Console.WriteLine("{0} , {1} ",osoba.Ime,osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());

            Osoba.Izvedi();
            // Console.WriteLine(osoba.Izvedi()); ne možeš pozvati statičnu metodu na objektu

            Mjesto mjesto = new Mjesto() { Naziv = "Osijek", PostanskiBroj = "31000" };

            osoba.Mjesto = mjesto;

        }

    }
}
