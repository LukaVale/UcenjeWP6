using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            try
            {
                int brojRedaka = Metode.UcitajCijeliPozitivniBroj("Unesite broj redaka tablice: ");

                int brojStupaca = Metode.UcitajCijeliPozitivniBroj("Unesite broj stupaca tablice: ");

                int[,] tablica = new int[brojRedaka, brojStupaca];

                int odabir = Metode.UcitajCijeliBroj("Odaberite način obilaska petlje:\n\n" +
                    "\t*Upišite 1 za rastući redosljed brojeva.\n\n" +
                    "\t*Upišite 2 za padajući redosljed brojeva.",1,2);
                
                if (odabir==1)
                {
                    odabir = Metode.UcitajCijeliBroj("Odaberite početnu poziciju:\n\n" +
                        "\t1 - Donji desni kut.\n" +
                        "\t2 - Donji lijevi kut\n" +
                        "\t3 - Gornji lijevi kut\n" +
                        "\t4 - Gornji desni kut", 1,4);

                    switch (odabir)
                    {
                        case 1:
                            tablica = CiklusDoljeDesno(brojRedaka, brojStupaca);
                            IspisTablice(tablica);
                            break;

                        case 2:
                            tablica = CiklusDoljeLijevo(brojRedaka, brojStupaca);
                            IspisTablice(tablica);
                            break;

                        case 3:
                            tablica = CiklusGoreLijevo(brojRedaka, brojStupaca);
                            IspisTablice(tablica);
                            break;

                        case 4:
                            tablica = CiklusGoreDesno(brojRedaka, brojStupaca);
                            IspisTablice(tablica);
                            break;
                    }
                }

                else if (odabir==2)
                {
                    odabir = Metode.UcitajCijeliBroj("Odaberite početnu poziciju:\n\n" +
                            "\t1 - Donji desni kut.\n" +
                            "\t2 - Donji lijevi kut\n" +
                            "\t3 - Gornji lijevi kut\n" +
                            "\t4 - Gornji desni kut", 1, 4);
                    switch (odabir)
                    {
                        case 1:
                            tablica = CiklusDoljeDesnoPadajuce(brojRedaka, brojStupaca);
                            IspisTablice(tablica);
                            break;

                        case 2:
                            tablica = CiklusDoljeLijevoPadajuce(brojRedaka, brojStupaca);
                            IspisTablice(tablica);
                            break;

                        case 3:
                            tablica = CiklusGoreLijevoPadajuce(brojRedaka, brojStupaca);
                            IspisTablice(tablica);
                            break;

                        case 4:
                            tablica = CiklusGoreDesnoPadajuce(brojRedaka, brojStupaca);
                            IspisTablice(tablica);
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Pogrešan unos!");
            }
        }

        public static int[,] CiklusDoljeDesno(int redak, int stupac)
        {
            int[,] tablica = new int[redak, stupac];

            int umnozak = redak * stupac;

            int korak = 1;
            int padajuciRedak = redak - 1,
                rastuciRedak = 0,
                padajuciStupac = stupac - 1,
                rastuciStupac = 0;



            while (korak <= umnozak)
            {
                for (int j = padajuciStupac; j >= rastuciStupac; j--)
                {
                    if (korak <= umnozak)
                    {
                        tablica[padajuciRedak, j] = korak++;
                    }

                }
                --padajuciRedak;


                for (int i = padajuciRedak; i >= rastuciRedak; i--)
                {
                    if (korak <= umnozak)
                    {
                        tablica[i, rastuciStupac] = korak++;
                    }
                }
                ++rastuciStupac;


                for (int j = rastuciStupac; j <= padajuciStupac; j++)
                {
                    if (korak <= umnozak)
                    {
                        tablica[rastuciRedak, j] = korak++;
                    }
                }
                ++rastuciRedak;


                for (int i = rastuciRedak; i <= padajuciRedak; i++)
                {
                    if (korak <= umnozak)
                    {
                        tablica[i, padajuciStupac] = korak++;
                    }
                }
                --padajuciStupac;
            }
            return tablica;
        }

        public static int[,] CiklusDoljeLijevo(int redak, int stupac)
        {
            int[,] tablica = new int[redak, stupac];

            int umnozak = redak * stupac;

            int korak = 1;
            int padajuciRedak = redak - 1,
                rastuciRedak = 0,
                padajuciStupac = stupac - 1,
                rastuciStupac = 0;

            while (korak <= umnozak)
            {
                for (int i = padajuciRedak; i >= rastuciRedak; i--)
                {
                    if (korak <= umnozak)
                    {
                        tablica[i, rastuciStupac] = korak++;
                    }
                }
                ++rastuciStupac;


                for (int j = rastuciStupac; j <= padajuciStupac; j++)
                {
                    if (korak <= umnozak)
                    {
                        tablica[rastuciRedak, j] = korak++;
                    }
                }
                ++rastuciRedak;


                for (int i = rastuciRedak; i <= padajuciRedak; i++)
                {
                    if (korak <= umnozak)
                    {
                        tablica[i, padajuciStupac] = korak++;
                    }
                }
                --padajuciStupac;

                for (int j = padajuciStupac; j >= rastuciStupac; j--)
                {
                    if (korak <= umnozak)
                    {
                        tablica[padajuciRedak, j] = korak++;
                    }

                }
                --padajuciRedak;
            }
            return tablica;
        }

        public static int[,] CiklusGoreLijevo(int redak, int stupac)
        {
            int[,] tablica = new int[redak, stupac];

            int umnozak = redak * stupac;

            int korak = 1;
            int padajuciRedak = redak - 1,
                rastuciRedak = 0,
                padajuciStupac = stupac - 1,
                rastuciStupac = 0;

            while (korak <= umnozak)
            {
                for (int j = rastuciStupac; j <= padajuciStupac; j++)
                {
                    if (korak <= umnozak)
                    {
                        tablica[rastuciRedak, j] = korak++;
                    }
                }
                ++rastuciRedak;


                for (int i = rastuciRedak; i <= padajuciRedak; i++)
                {
                    if (korak <= umnozak)
                    {
                        tablica[i, padajuciStupac] = korak++;
                    }
                }
                --padajuciStupac;

                for (int j = padajuciStupac; j >= rastuciStupac; j--)
                {
                    if (korak <= umnozak)
                    {
                        tablica[padajuciRedak, j] = korak++;
                    }

                }
                --padajuciRedak;


                for (int i = padajuciRedak; i >= rastuciRedak; i--)
                {
                    if (korak <= umnozak)
                    {
                        tablica[i, rastuciStupac] = korak++;
                    }
                }
                ++rastuciStupac;
            }
            return tablica;
        }

        public static int[,] CiklusGoreDesno(int redak, int stupac)
        {
            int[,] tablica = new int[redak, stupac];

            int umnozak = redak * stupac;

            int korak = 1;
            int padajuciRedak = redak - 1,
                rastuciRedak = 0,
                padajuciStupac = stupac - 1,
                rastuciStupac = 0;


            while (korak <= umnozak)
            {
                for (int i = rastuciRedak; i <= padajuciRedak; i++)
                {
                    if (korak <= umnozak)
                    {
                        tablica[i, padajuciStupac] = korak++;
                    }
                }
                --padajuciStupac;

                for (int j = padajuciStupac; j >= rastuciStupac; j--)
                {
                    if (korak <= umnozak)
                    {
                        tablica[padajuciRedak, j] = korak++;
                    }

                }
                --padajuciRedak;


                for (int i = padajuciRedak; i >= rastuciRedak; i--)
                {
                    if (korak <= umnozak)
                    {
                        tablica[i, rastuciStupac] = korak++;
                    }
                }
                ++rastuciStupac;


                for (int j = rastuciStupac; j <= padajuciStupac; j++)
                {
                    if (korak <= umnozak)
                    {
                        tablica[rastuciRedak, j] = korak++;
                    }
                }
                ++rastuciRedak;
            }
            return tablica;
        }

        public static int[,] CiklusDoljeDesnoPadajuce(int redak, int stupac)
        {
            int[,] tablica = new int[redak, stupac];

            int umnozak = redak * stupac;

            int padajuciRedak = redak - 1,
                rastuciRedak = 0,
                padajuciStupac = stupac - 1,
                rastuciStupac = 0;

            while (umnozak > 0)
            {
                for (int j = padajuciStupac; j >= rastuciStupac; j--)
                {
                    if (umnozak > 0)
                    {
                        tablica[padajuciRedak, j] = umnozak--;
                    }

                }
                --padajuciRedak;


                for (int i = padajuciRedak; i >= rastuciRedak; i--)
                {
                    if (umnozak > 0)
                    {
                        tablica[i, rastuciStupac] = umnozak--;
                    }
                }
                ++rastuciStupac;


                for (int j = rastuciStupac; j <= padajuciStupac; j++)
                {
                    if (umnozak > 0)
                    {
                        tablica[rastuciRedak, j] = umnozak--;
                    }
                }
                ++rastuciRedak;


                for (int i = rastuciRedak; i <= padajuciRedak; i++)
                {
                    if (umnozak > 0)
                    {
                        tablica[i, padajuciStupac] = umnozak--;
                    }
                }
                --padajuciStupac;
            }
            return tablica;
        }

        public static int[,] CiklusDoljeLijevoPadajuce(int redak, int stupac)
        {
            int[,] tablica = new int[redak, stupac];

            int umnozak = redak * stupac;

            int padajuciRedak = redak - 1,
                rastuciRedak = 0,
                padajuciStupac = stupac - 1,
                rastuciStupac = 0;

            while (umnozak > 0)
            {
                for (int i = padajuciRedak; i >= rastuciRedak; i--)
                {
                    if (umnozak > 0)
                    {
                        tablica[i, rastuciStupac] = umnozak--;
                    }
                }
                ++rastuciStupac;


                for (int j = rastuciStupac; j <= padajuciStupac; j++)
                {
                    if (umnozak > 0)
                    {
                        tablica[rastuciRedak, j] = umnozak--;
                    }
                }
                ++rastuciRedak;


                for (int i = rastuciRedak; i <= padajuciRedak; i++)
                {
                    if (umnozak > 0)
                    {
                        tablica[i, padajuciStupac] = umnozak--;
                    }
                }
                --padajuciStupac;

                for (int j = padajuciStupac; j >= rastuciStupac; j--)
                {
                    if (umnozak > 0)
                    {
                        tablica[padajuciRedak, j] = umnozak--;
                    }

                }
                --padajuciRedak;
            }
            return tablica;
        }

        public static int[,] CiklusGoreLijevoPadajuce(int redak, int stupac)
        {
            int[,] tablica = new int[redak, stupac];

            int umnozak = redak * stupac;

            int padajuciRedak = redak - 1,
                rastuciRedak = 0,
                padajuciStupac = stupac - 1,
                rastuciStupac = 0;

            while (umnozak > 0)
            {
                for (int j = rastuciStupac; j <= padajuciStupac; j++)
                {
                    if (umnozak > 0)
                    {
                        tablica[rastuciRedak, j] = umnozak--;
                    }
                }
                ++rastuciRedak;


                for (int i = rastuciRedak; i <= padajuciRedak; i++)
                {
                    if (umnozak > 0)
                    {
                        tablica[i, padajuciStupac] = umnozak--;
                    }
                }
                --padajuciStupac;

                for (int j = padajuciStupac; j >= rastuciStupac; j--)
                {
                    if (umnozak > 0)
                    {
                        tablica[padajuciRedak, j] = umnozak--;
                    }

                }
                --padajuciRedak;

                for (int i = padajuciRedak; i >= rastuciRedak; i--)
                {
                    if (umnozak > 0)
                    {
                        tablica[i, rastuciStupac] = umnozak--;
                    }
                }
                ++rastuciStupac;
            }
            return tablica;
        }

        public static int[,] CiklusGoreDesnoPadajuce(int redak, int stupac)
        {
            int[,] tablica = new int[redak, stupac];

            int umnozak = redak * stupac;

            int padajuciRedak = redak - 1,
                rastuciRedak = 0,
                padajuciStupac = stupac - 1,
                rastuciStupac = 0;

            while (umnozak > 0)
            {

                for (int i = rastuciRedak; i <= padajuciRedak; i++)
                {
                    if (umnozak > 0)
                    {
                        tablica[i, padajuciStupac] = umnozak--;
                    }
                }
                --padajuciStupac;

                for (int j = padajuciStupac; j >= rastuciStupac; j--)
                {
                    if (umnozak > 0)
                    {
                        tablica[padajuciRedak, j] = umnozak--;
                    }

                }
                --padajuciRedak;

                for (int i = padajuciRedak; i >= rastuciRedak; i--)
                {
                    if (umnozak > 0)
                    {
                        tablica[i, rastuciStupac] = umnozak--;
                    }
                }
                ++rastuciStupac;

                for (int j = rastuciStupac; j <= padajuciStupac; j++)
                {
                    if (umnozak > 0)
                    {
                        tablica[rastuciRedak, j] = umnozak--;
                    }
                }
                ++rastuciRedak;
            }
            return tablica;
        }


        public static void IspisTablice(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0, 10}", tablica[i, j] + " "));
                }
                Console.WriteLine();
            }
        }

    }
}
