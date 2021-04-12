using _2021_04_12_PARDUOTUVE.Database;
using _2021_04_12_PARDUOTUVE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_12_PARDUOTUVE.Services
{
    public class BatuParduotuve : IBatuParduotuve
    {
        private readonly IManageParduotuve _manageParduotuve;
        public BatuParduotuve(IManageParduotuve manageParduotuve)
        {
            _manageParduotuve = manageParduotuve;
        }
        public void Pirkti()
        {
            Console.Clear();
            while (true)
            {
                var batai = _manageParduotuve.GetAllBatas();
                IsvestiEkrananVisusBatus(batai);

                Console.WriteLine("Pasirinkite ka norite pirkti (iveskite batu nr.):");
                //apsirasyti kad tikrintu ar ivestas skaicius
                int batasId = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Pasirinkite dydi: ");
                var pasirinktasBatas = batai.FirstOrDefault(b=>b.BatasId==batasId);
                foreach (var dydis in pasirinktasBatas.Dydziai)
                {
                    Console.WriteLine($"{dydis.Dydis} turimas kiekis - {dydis.Kiekis}");
                }
                var pasirinktasDydis = int.Parse(Console.ReadLine());
                Console.WriteLine("\nNurodykite perkama kieki");
                var pasirinktasBatuDydis = pasirinktasBatas.Dydziai.FirstOrDefault(d=>d.Dydis==pasirinktasDydis);
                int kiekis = int.MaxValue;
                while (kiekis > pasirinktasBatuDydis.Kiekis)
                {
                    kiekis = int.Parse(Console.ReadLine());
                    if (kiekis > pasirinktasBatuDydis.Kiekis) Console.WriteLine("Neteisingas kiekis, iveskite dar karta");
                }
                _manageParduotuve.InsertPardavimasIrSumazintiKieki(pasirinktasBatuDydis.BatasId ,kiekis);



                Console.WriteLine("\nAr testi pirkima t/n ?");
                if (Console.ReadKey().Key == ConsoleKey.N) return;
            }
        }



        private void IsvestiEkrananVisusBatus(List<Batas> batai)
        {
            Console.WriteLine("Turimi batai: ");
            foreach (var batas in batai)
            {
                Console.WriteLine($"{batas.BatasId} {batas.Tipas} {batas.Pavadinimas} {batas.Kaina}");
            }
        }
    }
}