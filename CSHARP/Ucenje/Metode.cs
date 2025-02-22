using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Metode
    {
        public static int UcitajCijeliBroj(string poruka)
        {

            while (true)
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }


            // return 0; // kasnije obrisati
        }

        public static int UcitajCijeliBroj(string poruka, int min, int max)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} - {1}", min, max);
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }

        }

        public static int UcitajCijeliBroj(int min, int max)
        {
            int i;
            while (true)
            {
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i < min || i > max)
                    {
                        Console.WriteLine("Broj nije u danom rasponu {0} - {1}", min, max);
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }


            // return 0; // kasnije obrisati
        }

        public static int UcitajCijeliPozitivniBroj(string poruka)
        {
            int i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i < 0)
                    {
                        Console.WriteLine("Uneseni broj je negativan");
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }


            // return 0; // kasnije obrisati
        }

        public static double UcitajPozitivniBroj(string poruka)
        {
            double  i;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    i = double.Parse(Console.ReadLine());
                    if (i < 0)
                    {
                        Console.WriteLine("Uneseni broj je negativan");
                        continue;
                    }
                    return i;
                }
                catch
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                }
            }
        }

        public static string UcitajString(string poruka)
        {
            string s = "";
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }

            // return "";
        }

    }
}
