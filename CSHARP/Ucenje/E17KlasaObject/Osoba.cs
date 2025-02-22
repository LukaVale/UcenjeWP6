using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObject
{
    // Klasa je opisnik objekta
    // Objekt je instanca klase
    internal class Osoba
    {
        //klasa sadrži svojstva (property)
        public int Sifra { get; set; } //OOP princip učahurivanja
        public string? Ime { get; set; } // ? označava kako ime može biti null
        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }

        public string ImePrezime()
        {
            Console.WriteLine("Izvođenje metode s objekta");
            return Ime + " " + Prezime;
        }

        public static void Izvedi()
        {
            Console.WriteLine("Izvođenje statične metode s klase");
        }

    }
}
