using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadatci
    {
        public static void Izvedi()
        {
            //Zadatak1();
            //Zadatak2();
            //Zadatak3();
            //Zadatak4();
            //Zadatak5();
            //Zadatak6();
            //Zadatak7();
            //Zadatak8();
            //Zadatak9();
            //Zadatak10();
            
        }
        private static void Zadatak1()
        {
            Console.WriteLine("Unesi duljinu pravokutnika: ");
            int duljinaP = int.Parse(Console.ReadLine());

            if (duljinaP < 0)
            {
                Console.WriteLine("Uneseni broj mora biti veći od 0");
                return;
            }

            Console.WriteLine("Unesi širinu pravokutnika: ");
            int sirinaP = int.Parse(Console.ReadLine());

            int povrsina;
            povrsina = duljinaP * sirinaP;

            Console.WriteLine("Površina pravokutnika je: " + povrsina);

        }

        private static void Zadatak2()
        {
            Console.WriteLine("Unesi pozitivan ili negativan broj ili nulu");
            int broj = int.Parse(Console.ReadLine());

            if (broj < 0)
            {
                Console.WriteLine("Uneseni broj je negativan");
                return;
            }
            else if (broj > 0)
            {
                Console.WriteLine("Uneseni broj je pozitivan");
                return;
            }
            else { Console.WriteLine("Uneseni broj je nula"); }
        }

        private static void Zadatak3()
        {
           
            
            // Traženje korisnika da odabere veličinu niza
           
            /* int n = Metode.UcitajCijeliBroj("Unesi broj elemenata niza koji je veći od 0: ");

            int[] niz = new int[n];
            int zbroj = 0;
            for (int i = 0; i < n; i++)
            {
                niz[i] = Metode.UcitajCijeliPozitivniBroj("Unesi " + i + " element u nizu koji je veći od 0: ");
                zbroj += niz[i];
            }
            Console.WriteLine("Ukupni zbroj elemenata niza je : " + zbroj); */

            // Predefinirana veličina niza
            int m = 10;
            Console.WriteLine("Ovaj niz se sastoji od: " +  m+ " elemenata, molim ispuni niz.");
            int[] niz1 = new int[m];
            int zbroj1 = 0;
            for (int i = 0; i < m; i++)
            {
                niz1[i] = Metode.UcitajCijeliPozitivniBroj("Unesi " + i + " element u nizu koji je veći od 0: ");
                zbroj1 += niz1[i];
            }
            Console.WriteLine("Ukupni zbroj elemenata niza je : " + zbroj1);

        }

        private static void Zadatak4()
        {
            int n = Metode.UcitajCijeliPozitivniBroj("Unesi broj ocjena: ");
            int[] niz = new int[n];
            int zbroj = 0;
            double brojac = 0;
            for (int i = 0; i < n; i++)
            {
                int ocjena = i + 1;
                niz[i] = Metode.UcitajCijeliBroj("Unesi " +ocjena  + ". ocjenu " , 1 , 5);
                zbroj += niz[i];
                brojac++;
            }
            double prosjek = 0;
            prosjek = zbroj / brojac;
            prosjek = Math.Round(prosjek, 2);
            Console.WriteLine("Tvoje ocjene su: " + string.Join(",",niz));
            Console.WriteLine("Prosjek tvojih ocjena je: " + prosjek);
        }

        private static void Zadatak5()
        {
            int n = Metode.UcitajCijeliBroj("Unesi veličinu niza: ");
            int[] niz = new int[n];
            int broj1, broj2 = 0;
            niz[0] = 0;
            niz[1] = 1;
            for (int i = 2;i < n;i++)
            {
                niz[i] = niz[i - 1] + niz[i - 2];
            }
            for (int i = 0; i < n;i++)
            {
                Console.WriteLine(niz[i]);
            }
            
        }

        private static void Zadatak6()
        {
            Console.WriteLine("Unesi string: ");
            string unos = Console.ReadLine();

            string okreni = "";
            for (int i = unos.Length - 1 ; i >= 0; i--)
            {
                okreni += unos[i];
            }
            Console.WriteLine("Okrenuti string je : " + okreni);
        }

        private static void Zadatak7()
        {
            Console.WriteLine("Unesi string: ");
            string unos = Console.ReadLine();

            int brojsamoglasnika = 0;
            foreach (char c in unos.ToLower())
            {
                if (c == 'a')
                {
                    brojsamoglasnika++;
                }
                else if (c == 'e')
                {
                    brojsamoglasnika++;
                }
                else if (c == 'i')
                {
                    brojsamoglasnika++;
                }
                else if (c == 'o')
                {
                    brojsamoglasnika++;
                }
                else if (c == 'u')
                {
                    brojsamoglasnika++;
                }
            }
            Console.WriteLine("Broj samoglasnika u stringu je: " + brojsamoglasnika);
        }

        private static void Zadatak8()
        {

            Console.WriteLine("Odaberi radnju: ");
            Console.WriteLine("1. Pretvaranje Celsijusa u Fahrenheit.");
            Console.WriteLine("2. Pretvaranje Fahrenheita u Celzijuse.");
            int odabir = Metode.UcitajCijeliBroj(1, 2);
            //int odabir = int.Parse(Console.ReadLine());
            switch (odabir)
            {
                case 1:
                    double tempC = Metode.UcitajPozitivniBroj("Unesi temperaturu u Celzijusima: ");

                    double CuF = tempC * 9 / 5 + 32;
                    CuF = Math.Round(CuF, 2);
                    Console.WriteLine("Temperatura u Fahrenheitima je: " + CuF);
                    break;
                case 2:
                    double tempF = Metode.UcitajPozitivniBroj("Unesi temperaturu u Fahrenheitima: ");

                    double FuC = (tempF - 32) * 5 / 9;
                    FuC = Math.Round(FuC, 2);
                    Console.WriteLine("Temperatura u Celzijuima je: " + FuC);
                    break;
                default:
                    Console.WriteLine("Uneseni broj nije ponuđenih radnji.");
                    break;
            }
        }

        private static void Zadatak9()
        {
            int n = Metode.UcitajCijeliBroj("Unesi broj elemenata niza koji je veći od 0: ");

            int[] niz = new int[n];
            for (int i = 0; i<n;i++)
            {
                niz[i] = Metode.UcitajCijeliPozitivniBroj("Unesi " + (i+1) + " element u nizu koji je veći od 0: ");
            }
            
            for (int i = 0; i < n-1; i++)
            {
                for (int j =0; j < n-1-i; j++)
                {   
                    if (niz[j] > niz[j+1])
                    {
                        int najmanji = niz[j];
                        niz[j] = niz[j+1];
                        niz[j+1] = najmanji;
                    }

                }

            }
            Console.WriteLine(String.Join(",",niz));  
        }

        private static void Zadatak10()
        {
            Console.WriteLine("Unesi dva broja i nakon toga odaberi što želiš učiniti s njima (+,-,*,/)");
            int prvibroj = Metode.UcitajCijeliPozitivniBroj("Unesi prvi broj: ");
            int drugibroj = Metode.UcitajCijeliPozitivniBroj("Unesi drugi broj: ");
            Console.WriteLine("1. Zbrajanje");
            Console.WriteLine("2. Oduzimanje");
            Console.WriteLine("3. Množenje");
            Console.WriteLine("4. Dijeljenje");
            int radnja = Metode.UcitajCijeliBroj(1, 4);
            double rezultat = 0;

            switch (radnja)
            {
                case 1:
                    rezultat = prvibroj + drugibroj;
                    break;
                case 2:
                    rezultat = prvibroj - drugibroj;
                    break;
                case 3:
                    rezultat = prvibroj * drugibroj;
                    break;
                case 4:
                    if (radnja == 0)
                    {
                        Console.WriteLine("Nije moguće dijeliti s nulom");
                        return;
                    }
                    rezultat = (double)prvibroj / drugibroj;
                    break;
            }
            Console.WriteLine("Rezultat odabranje radnje je: " + rezultat);
        }

        
    }
}

      //Zimski zadaci:

       /* Jednostavni
       1. Izračun površine pravokutnika:
           Napiši program koji od korisnika traži da unese duljinu i širinu pravokutnika, a zatim izračunava i ispisuje površinu pravokutnika.
       2. Provjera je li broj pozitivan, negativan ili nula:
           Napiši program koji od korisnika traži da unese broj i ispisuje je li broj pozitivan, negativan ili nula.
       3. Zbroj elemenata niza:
           Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim izračunava i ispisuje zbroj svih elemenata niza.
       4. Prosjek ocjena:
           Napiši program koji od korisnika traži da unese broj ocjena, a zatim i same ocjene. Program treba izračunati i ispisati prosjek ocjena.
       5. Ispis Fibonaccijevog niza:
           Napiši program koji od korisnika traži da unese broj n, a zatim ispisuje prvih n brojeva Fibonaccijevog niza (0, 1, 1, 2, 3, 5, 8...).
       6. Preokret stringa:
           Napiši program koji od korisnika traži da unese string, a zatim ispisuje taj string naopako (npr. "zdravo" postaje "ovardz").
       7. Brojanje samoglasnika:
           Napiši program koji od korisnika traži da unese string, a zatim prebrojava i ispisuje koliko samoglasnika ima u tom stringu.
       8. Pretvorba temperature:
           Napiši program koji od korisnika traži da unese temperaturu u Celzijusima i pretvara je u Fahrenheit (°F = °C * 9/5 + 32) ili obrnuto, ovisno o odabiru korisnika.
       9. Sortiranje niza:
           Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim sortira niz uzlazno i ispisuje sortirani niz.
       10. Kalkulator:
           Napiši program koji od korisnika traži da unese dva broja i operaciju (+, -, *, /), a zatim izračunava i ispisuje rezultat. Koristi switch statement za odabir operacije.
       */
/*
      Generator lozinki
          Program od korisnika traži unos podataka:
          Dužina lozinke
          Uključena/isključena velika slova
          Uključena/isključena mala slova
          Uključeni/isključeni brojevi
          Uključeni/isključeni interpunkcijski znakovi
          Lozinka počinje ili ne s brojem
          Lozinka počinje ili ne s interpunkcijskim znakom
          Lozinka završava ili ne s brojem
          Lozinka završava ili ne s interpunkcijskim znakom
          Lozinka ima/nema ponavljajuće znakove
          Broj lozinki koje je potrebno generirati

          Shodno unesenim pravilima program generira rezultat (jedna ili više lozinki)


      Ciklična matrica
      Napraviti osnovni zadatak prema inicijalnoj slici
      Dodatno:
      Osigurati unos brojeva redova i kolona u rasponu 2 do 50
      Napraviti da nakon završetka generiranja jedne matrice pita želite li napraviti još jednu i tako sve dok ne unese NE
      Napraviti opcije programa o smjeru kretanja brojeva:
      1. dolje desno početak u smjeru kazaljke na satu (inicijalni zadatak)
      2. dolje lijevo početak u smjeru kazaljke na satu
      3. gore lijevo početak u smjeru kazaljke na satu
      4. gore desno početak u smjeru kazaljke na satu

      5. dolje desno početak u kontra smjeru kazaljke na satu 
      6. dolje lijevo početak u kontra smjeru kazaljke na satu
      7. gore lijevo početak u kontra smjeru kazaljke na satu
      8. gore desno početak u kontra smjeru kazaljke na satu

      19. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u smjeru kazaljke na satu
      10. sredina (ono što je bio kraj u prvih 8 primjera) desno u smjeru kazaljke na satu
      11. sredina (ono što je bio kraj u prvih 8 primjera) gore u smjeru kazaljke na satu
      12. sredina (ono što je bio kraj u prvih 8 primjera) dolje u smjeru kazaljke na satu

      13. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u kontra smjeru kazaljke na satu
      14. sredina (ono što je bio kraj u prvih 8 primjera) desno u kontra smjeru kazaljke na satu
      15. sredina (ono što je bio kraj u prvih 8 primjera) gore u kontra smjeru kazaljke na satu
      16. sredina (ono što je bio kraj u prvih 8 primjera) dolje u kontra smjeru kazaljke na satu

      Formatirati brojeve da budu potpisati po pravilima matematike: jedinica ispod jedinice, desetica ispod desetice, stotica ispod stotice






      Ljubavni kalkulator
      Napraviti osnovni zadatak prema inicijalnoj slici koristeći rekurziju
      Dodatno:
      Osigurati unos imena (smije imati samo slova, bez brojeva i interpunkcijskih znakova)
      promijeniti algoritam da zbraja dva susjedna broja (1 i 2, 3 i 4, 5 i 6, itd.) umjesto osnovnog algoritma 1 i zadnji, drugi i predzadnji itd.
      Umjesto rekurzije koristiti petlju po izboru









      Kada završite sve zadatke s svim opcijama javite se na email pa ću poslati nove :)






       */
