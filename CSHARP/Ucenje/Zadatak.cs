using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Zadatak
    {
        public static void Izvedi()
        {
            int i;
            Console.Write("Unesi svoje ime: "); 
          
            string Ime = Console.ReadLine();

            Console.Write("Upiši broj godina: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Osoba {0} ima {1} godina ", Ime, i);

        }
    }
}
