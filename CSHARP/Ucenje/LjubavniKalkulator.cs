using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class LjubavniKalkulator
    {
        public static void Main()
        {
            LjubavniKalkulator kalkulator = new LjubavniKalkulator(); // Kreiranje instance
            kalkulator.Izvedi();
        }
        public void Izvedi()
        {
            Ljubav();
        }

        public void Ljubav()
        {
            var ona = "Marta";
            var on = "Manuel";

            var izraz = ona.Trim().ToLower() + on.Trim().ToLower();

            Console.WriteLine(izraz);
            var brojevi = PrebrojiZnakove(izraz);

            Console.WriteLine(string.Join(" ", brojevi));

            while (brojevi.Length > 2)
            {
                brojevi = ZbrojiBrojeve(brojevi);
                Console.WriteLine(string.Join(" ", brojevi));
            }

            // Ispisujemo rezultat ljubavi
            int postotak = brojevi[0] * 10 + brojevi[1];
            Console.WriteLine("Postotak ljubavi: " + postotak);
        }

        private int[] PrebrojiZnakove(string izraz)
        {
            int[] brojevi = new int[izraz.Length];
            var ponovilose = 0;
            for (int i = 0; i < izraz.Length; i++)
            {
                ponovilose = 0;
                for (int j = 0; j < izraz.Length; j++)
                {
                    if (izraz[i] == izraz[j])
                    {
                        ponovilose++;
                    }
                }
                brojevi[i] = ponovilose;

            }
            return brojevi;
        }

        private int[] ZbrojiBrojeve(int[] brojevi)
        {
            int duljina = brojevi.Length;
            int novaDuljina = (duljina + 1) / 2;  // Nova duljina niza nakon zbrajanja
            int[] noviBrojevi = new int[novaDuljina];

            int carry = 0;  // Varijabla za prijenos ostatka

            // Zbrajanje brojeva sa suprotnim indeksima
            for (int i = 0; i < novaDuljina; i++)
            {
                int zadnjiBroj = duljina - 1 - i;  // Indeks za suprotan broj

                int zbroj = brojevi[i] + brojevi[zadnjiBroj] + carry; // Zbrajanje s prijenosom

                if (i == zadnjiBroj)
                {
                    noviBrojevi[i] = zbroj;  // Ako je broj na sredini
                }
                else
                {
                    noviBrojevi[i] = zbroj % 10;  // Jedinice zbroja
                    carry = zbroj / 10;  // Desetice idu u prijenos
                }
            }

            // Provjera da li je u sredini niza ostao višak
            if (novaDuljina == 2 && carry > 0)
            {
                noviBrojevi[1] += carry;  // Dodajemo prijenos u zadnji broj
            }

            return noviBrojevi;
        }
    }
}

