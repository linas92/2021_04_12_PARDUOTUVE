using _2021_04_12_PARDUOTUVE.Models;

namespace _2021_04_12_PARDUOTUVE.InitialData
{
    public static class BatuDydisInitialData
    {
        public static BatuDydis[] DataSeed => new BatuDydis[]
            {
            new BatuDydis{BatuDydisId = 1, BatasId = 1, Dydis = 42, Kiekis = 10},
            new BatuDydis{BatuDydisId = 2, BatasId = 1, Dydis = 43, Kiekis = 10},
            new BatuDydis{BatuDydisId = 3, BatasId = 1, Dydis = 44, Kiekis = 10},
            new BatuDydis{BatuDydisId = 4, BatasId = 1, Dydis = 45, Kiekis = 10},

            new BatuDydis{BatuDydisId = 5, BatasId = 2, Dydis = 36, Kiekis = 10},
            new BatuDydis{BatuDydisId = 6, BatasId = 2, Dydis = 37, Kiekis = 11},
            new BatuDydis{BatuDydisId = 7, BatasId = 2, Dydis = 38, Kiekis = 12},
            new BatuDydis{BatuDydisId = 8, BatasId = 2, Dydis = 39, Kiekis = 13},

            new BatuDydis{BatuDydisId = 9, BatasId = 3, Dydis = 30, Kiekis = 14},
            new BatuDydis{BatuDydisId = 10, BatasId = 3, Dydis = 31, Kiekis = 15},
            new BatuDydis{BatuDydisId = 11, BatasId = 3, Dydis = 32, Kiekis = 16},
            new BatuDydis{BatuDydisId = 12, BatasId = 3, Dydis = 33, Kiekis = 17},
            };
    }
}
