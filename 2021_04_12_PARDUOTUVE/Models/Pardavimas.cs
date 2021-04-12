using System.ComponentModel.DataAnnotations;

namespace _2021_04_12_PARDUOTUVE.Models
{
    public class Pardavimas
    {
        [Key]
        public int PardavimasId { get; set; }
        public int Kiekis { get; set; }
        public int BatuDydisId { get; set; }
        public BatuDydis BatuDydis { get; set; }
        public decimal Isleista => Kiekis * BatuDydis.Batas.Kaina;
    }
}