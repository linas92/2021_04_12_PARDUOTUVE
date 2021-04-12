using _2021_04_12_PARDUOTUVE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_12_PARDUOTUVE.Database
{
    public class ManageParduotuve : IManageParduotuve
    {
        private readonly ParduotuveContext _context;
        public ManageParduotuve(ParduotuveContext context)
        {
            _context = context;
            context.Database.EnsureCreated();
        }
        public List<Batas> GetAllBatas()
        {
            return _context.Batai.Include(x => x.Dydziai).ToList();
        }
        public void InsertPardavimasIrSumazintiKieki(int batuDydzioId, int kiekis)
        {
            if(kiekis < 1) return;
            _context.Pardavimai.Add(new Pardavimas{ BatuDydisId=batuDydzioId, Kiekis = kiekis });
            var batuDydisKurioKiekiReikiaSumazinti = _context.BatuDydziai.Find(batuDydzioId);
            batuDydisKurioKiekiReikiaSumazinti.Kiekis-=kiekis;
            _context.SaveChanges();


        }
    }
}