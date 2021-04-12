using _2021_04_12_PARDUOTUVE.Database;
using _2021_04_12_PARDUOTUVE.Services;
using System;

namespace _2021_04_12_PARDUOTUVE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ParduotuveContext()) 
            {
                IManageParduotuve manageParduotuve = new ManageParduotuve(context);
                IBatuParduotuve batuParduotuve = new BatuParduotuve(manageParduotuve);
                batuParduotuve.Pirkti();


            }





            Console.ReadKey();
            Console.WriteLine("Goodbye Sad World!");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}