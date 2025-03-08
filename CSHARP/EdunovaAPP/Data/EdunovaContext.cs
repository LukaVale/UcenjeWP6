using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace EdunovaAPP.Data
{
    public class EdunovaContext :DbContext
    {
        public EdunovaContext(DbContextOptions<EdunovaContext> options): base(options)
        {
            // Ovdje se upravlja konfiguracijom baze podataka
        }

        public DbSet<Smjer> Smjerovi { get; set; } // zbog ovog ovdje Smjerovi se tablica zove u mnozini


    }
}
