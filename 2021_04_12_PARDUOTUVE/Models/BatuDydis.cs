using System.ComponentModel.DataAnnotations;

namespace _2021_04_12_PARDUOTUVE.Models
{
    public class BatuDydis
    {
        [Key]
        public int BatuDydisId { get; set; }
        public int Dydis { get; set; }
        public int Kiekis { get; set; }
        public int BatasId { get; set; }
        public Batas Batas { get; set; }
    }
}