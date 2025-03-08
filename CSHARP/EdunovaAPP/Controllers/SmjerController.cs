using Microsoft.AspNetCore.Mvc;
using EdunovaAPP.Data;
namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController :ControllerBase
    {
        // Koristimo depenedency injection
        // 1. Definiramo privatno svojstvo

        private readonly EdunovaContext _context;

        // 2. Prosljediš instancu kroz konstruktor
        public SmjerController(EdunovaContext context)
        {
            // 2. Inicijaliziramo svojstvo
            _context = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
           try
            {
                return Ok(_context.Smjerovi);
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
