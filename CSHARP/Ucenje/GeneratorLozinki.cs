using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class GeneratorLozinki
    {
        public static void Izvedi()
        {
            GeneratorLozinkiApp();
        }
        private static void GeneratorLozinkiApp()
        {
            Console.WriteLine("Dobrodošao u generator lozinki");
            Console.WriteLine("Kako bi program uspješno generirao tvoje lozinke, moraš mu ispuniti sljedeće zahtjeve");
            LozinkeIzbornik();
        }
        private static void LozinkeIzbornik()
        {
            Random rand = new Random();

            bool pocetakBroj = false;
            bool krajBroj = false;
            bool pocetakInterpunkcija = false;
            bool krajInterpunkcija = false;
            bool uvjetVelikaS = false;
            bool uvjetMalaS = false;
            bool uvjetBrojevi = false;
            bool uvjetInterpunkcija = false;
            bool pocetakLozinka = false;
            bool krajLozinka = false;
            int brojOpcija = 0;
            int brojDostupnihZnakova = 0;


            int duzinaLozinke = Metode.UcitajCijeliPozitivniBroj("Unesi duljinu lozinke brojčano: ");

            do
            {
                uvjetVelikaS = Metode.UcitajCijeliBroj("Uključiti velika slova? (1=Da, 2=Ne): ", 1, 2) == 1;
                uvjetMalaS = Metode.UcitajCijeliBroj("Uključiti mala slova? (1=Da, 2=Ne): ", 1, 2) == 1;
                uvjetBrojevi = Metode.UcitajCijeliBroj("Uključiti brojeve? (1=Da, 2=Ne): ", 1, 2) == 1;
                uvjetInterpunkcija = Metode.UcitajCijeliBroj("Uključiti interpunkcijske znakove? (1=Da, 2=Ne) :", 1, 2) == 1;

                if (!uvjetVelikaS && !uvjetMalaS && !uvjetBrojevi && !uvjetInterpunkcija)
                {
                    Console.WriteLine("Nisi odabrao niti jednu opciju za lozinku, ne mogu generirati lozinku bez ijednog uvjeta! ");
                }

            } while (!uvjetVelikaS && !uvjetMalaS && !uvjetBrojevi && !uvjetInterpunkcija);

            if (uvjetVelikaS)
            {
                brojOpcija++;
                brojDostupnihZnakova += 26;
            }
            if (uvjetMalaS)
            {
                brojOpcija++;
                brojDostupnihZnakova += 26;
            }
            if (uvjetBrojevi)
            {
                brojOpcija++;
                brojDostupnihZnakova += 10;
            }
            if (uvjetInterpunkcija)
            {
                brojOpcija++;
                brojDostupnihZnakova += 15;
            }

            if (brojOpcija > 1)
            {
                do
                {
                    if (uvjetBrojevi)
                    {
                        pocetakBroj = Metode.UcitajCijeliBroj("Lozinka počinje s brojem? (1 = Da, 2 = Ne): ", 1, 2) == 1;
                        krajBroj = Metode.UcitajCijeliBroj("Lozinka završava s brojem? (1 = Da, 2 = Ne): ", 1, 2) == 1;
                    }

                    if (uvjetInterpunkcija)
                    {
                        pocetakInterpunkcija = Metode.UcitajCijeliBroj("Lozinka počinje s interpunkcijskim znakom? (1 = Da, 2 = Ne): ", 1, 2) == 1;
                        krajInterpunkcija = Metode.UcitajCijeliBroj("Lozinka završava s interpunkcijskim znakom? (1 = Da, 2 = Ne): ", 1, 2) == 1;
                    }
                    if ((pocetakBroj && pocetakInterpunkcija) || krajBroj && krajInterpunkcija)
                    {
                        Console.WriteLine("Lozinka istovremeno ne može počinjati i sa brojem i sa interpunkcijom! ");
                    }
                }
                while ((pocetakBroj && pocetakInterpunkcija) || krajBroj && krajInterpunkcija);
            }
            bool ponavljanje = Metode.UcitajCijeliBroj("Lozinka ima ponavljajuće znakove? (1 = Da, 2 = Ne): ", 1, 2) == 1;

            int brojLozinki = Metode.UcitajCijeliBroj("Koliko lozinki generirati? ", 1, 100);

            string dozvoljeniZnakovi = "";
            if (uvjetVelikaS) dozvoljeniZnakovi += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (uvjetMalaS) dozvoljeniZnakovi += "abcdefghijklmnopqrstuvwxyz";
            if (uvjetBrojevi) dozvoljeniZnakovi += "0123456789";
            if (uvjetInterpunkcija) dozvoljeniZnakovi += "!@#$%^&*()_-+=<>?";

            if (brojDostupnihZnakova < duzinaLozinke && !ponavljanje)
            {
                Console.WriteLine("Ne mogu generirati lozinku sa zadanim uvjetima: duljina lozinke je prevelika za jedinstvene znakove.");
                return;
            }

            for (int k = 0; k < brojLozinki; k++)
            {
                StringBuilder lozinka = new StringBuilder();
                char[] koristeniZnakovi = new char[duzinaLozinke];
                int brojac = 0;

                if (pocetakBroj)
                {
                    lozinka.Append("0123456789"[rand.Next(10)]);
                    koristeniZnakovi[brojac++] = lozinka[0];
                }
                else if (pocetakInterpunkcija)
                {
                    lozinka.Append("!@#$%^&*()_-+=<>?"[rand.Next(15)]);
                    koristeniZnakovi[brojac++] = lozinka[0];
                }


                for (int i = lozinka.Length; i < duzinaLozinke; i++)
                {
                    char randomChar;
                    bool isUsed;
                    do
                    {
                        randomChar = dozvoljeniZnakovi[rand.Next(dozvoljeniZnakovi.Length)];
                        isUsed = false;


                        for (int j = 0; j < brojac; j++)
                        {
                            if (koristeniZnakovi[j] == randomChar)
                            {
                                isUsed = true;
                                break;
                            }
                        }
                    } while (isUsed && ponavljanje);

                    lozinka.Append(randomChar);
                    if (brojac < koristeniZnakovi.Length)
                    {
                        koristeniZnakovi[brojac] = randomChar;
                        brojac++;
                    }

                }

                if (krajBroj)
                {
                    lozinka.Append("0123456789"[rand.Next(10)]);
                    if (brojac < koristeniZnakovi.Length)
                    {
                        koristeniZnakovi[brojac++] = lozinka[lozinka.Length - 1];
                    }
                }
                else if (krajInterpunkcija)
                {
                    lozinka.Append("!@#$%^&*()_-+=<>?"[rand.Next(15)]);
                    if (brojac < koristeniZnakovi.Length)
                    {
                        koristeniZnakovi[brojac++] = lozinka[lozinka.Length - 1];
                    }
                }
                Console.WriteLine("Generirana lozinka " + (k + 1) + ": " + lozinka.ToString());
            }

        }

    }
}
