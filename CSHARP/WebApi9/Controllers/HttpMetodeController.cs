using Microsoft.AspNetCore.Mvc;
using WebApi9.Models;

namespace WebApi9.Controllers
{
    /// <summary>
    /// Kontroler za rukovanje HTTP metodama.
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {
        /// <summary>
        /// Vraća jednostavnu poruku "Hello World!".
        /// </summary>
        /// <returns>Poruka "Hello World!".</returns>
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Vraća personaliziranu poruku dobrodošlice.
        /// </summary>
        /// <param name="ime">Ime koje će biti uključeno u poruku.</param>
        /// <returns>Poruka "Hello {ime}!".</returns>
        [HttpGet]
        [Route("helloworld")]
        public string HelloWorld(string ime)
        {
            return $"Hello {ime}!";
        }

        /// <summary>
        /// Vraća JSON objekt s danim šifrom i imenom.
        /// </summary>
        /// <param name="sifra">Šifra koja će biti uključena u JSON objekt.</param>
        /// <param name="ime">Ime koje će biti uključeno u JSON objekt.</param>
        /// <returns>JSON objekt.</returns>
        [HttpGet]
        [Route("json")]
        public IActionResult Json(int sifra, string ime)
        {
            return Ok(new { Sifra = sifra, Ime = ime });
        }

        /// <summary>
        /// Kreira novi objekt Osoba i vraća ga sa statusnim kodom 201.
        /// </summary>
        /// <param name="osoba">Objekt Osoba za kreiranje.</param>
        /// <returns>Kreirani objekt Osoba.</returns>
        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(201, osoba);
        }

        /// <summary>
        /// Ažurira postojeći objekt Osoba i vraća ga sa statusnim kodom 206.
        /// </summary>
        /// <param name="osoba">Objekt Osoba za ažuriranje.</param>
        /// <returns>Ažurirani objekt Osoba.</returns>
        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }

        /// <summary>
        /// Briše objekt Osoba na temelju dane šifre.
        /// </summary>
        /// <param name="sifra">Šifra objekta Osoba za brisanje.</param>
        /// <returns>Rezultat operacije brisanja.</returns>
        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { poruka = "Sifra mora biti veca od 0" });
            }
            return StatusCode(StatusCodes.Status204NoContent);
        }

    }
}
