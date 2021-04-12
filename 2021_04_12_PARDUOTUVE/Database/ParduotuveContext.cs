using _2021_04_12_PARDUOTUVE.InitialData;
using _2021_04_12_PARDUOTUVE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_04_12_PARDUOTUVE.Database
{
    public class ParduotuveContext : DbContext
    {
        public DbSet<Batas> Batai { get; set; }
        public DbSet<BatuDydis> BatuDydziai { get; set; }
        public DbSet<Pardavimas> Pardavimai { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInternalServiceProvider("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=_2020_07_23_EFCodeFirstDatabase.VartotojuDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Batas>()
                .Property(p=>p.Kaina)
                .HasPrecision(9,2);

            modelBuilder.Entity<Batas>().HasData(BatasInitialData.DataSeed);

            modelBuilder.Entity<BatuDydis>().HasData(BatuDydisInitialData.DataSeed);
        }
    }
}