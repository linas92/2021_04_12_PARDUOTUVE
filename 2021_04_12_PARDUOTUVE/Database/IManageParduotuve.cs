using _2021_04_12_PARDUOTUVE.Models;
using System.Collections.Generic;

namespace _2021_04_12_PARDUOTUVE.Database
{
    public interface IManageParduotuve
    {
        List<Batas> GetAllBatas();
        void InsertPardavimasIrSumazintiKieki(int batuDydzioId, int kiekis);
    }
}