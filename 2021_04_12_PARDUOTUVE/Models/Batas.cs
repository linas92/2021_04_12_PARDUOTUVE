using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_12_PARDUOTUVE.Models
{
    public class Batas
    {
        [Key]
        public int BatasId { get; set; }
        [Required, MaxLength(150)] // deklaruojame jeigu nullabul
        public string Pavadinimas { get; set; }
        [Required, MaxLength(10)]
        public string Tipas { get; set; } // moteriski, vyriski arba vaikiski
        public decimal Kaina { get; set; }
        public virtual List<BatuDydis> Dydziai { get; set; }
    }
}