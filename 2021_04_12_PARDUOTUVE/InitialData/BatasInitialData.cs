using _2021_04_12_PARDUOTUVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_12_PARDUOTUVE.InitialData
{
    public static class BatasInitialData
    {
        public static Batas[] DataSeed => new Batas[]
        {
            new Batas
            {
                BatasId = 1,
                Pavadinimas = "Kedai",
                Tipas = "Vyriski",
                Kaina = 100.99M,
            },
            new Batas
            {
                BatasId = 2,
                Pavadinimas = "Kedai",
                Tipas = "Moteriski",
                Kaina = 200.99M,
            },
            new Batas
            {
                BatasId = 3,
                Pavadinimas = "Kroksai",
                Tipas = "Vaikiski",
                Kaina = 20.99M,
            },
        };
    }
}