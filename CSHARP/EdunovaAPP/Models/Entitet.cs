using System.ComponentModel.DataAnnotations;

namespace EdunovaAPP.Models
{
    public abstract class Entitet
    {
        [Key] //s ovime odabiremo primarni ključ u bazi
        public int Sifra { get; set; }
    }
}
