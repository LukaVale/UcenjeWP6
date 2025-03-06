using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class test
    {

        public static void Izvedi()
        {
            try
            {
                // Dohvaćanje puta do "Dokumenti" mape
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = Path.Combine(docPath, "test_spremanja.json");

                // Testni JSON podatak
                string testData = "{\"ime\": \"Test\", \"vrijednost\": 123}";

                // Pisanje u datoteku
                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    outputFile.WriteLine(testData);
                }

                Console.WriteLine($"Datoteka uspješno spremljena na: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom spremanja: {ex.Message}");
            }




        }

    }
}
