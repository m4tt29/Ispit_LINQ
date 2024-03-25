using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispit_model;
using Ispit_model.Klase;

namespace Ispit.konzola
{
    public class Program
    {
        static void Main(string[] args)
        {
            var GrupirajPremaBanci = Podaci.ListaKlijenata
                                    .Where(k => k.Stanje >= 1000000)
                                    .GroupBy(k => k.Banka)
                                    .Select(g => new GrupiraniMilijunasi
                                    {
                                        Banka = g.Key,
                                        Milijunasi = g.Select(k => k.ImePrezime)
                                    });

            Console.WriteLine("Grupirani milijunaši po bankama:");
            foreach (var grupa in GrupirajPremaBanci)
            {
                Console.WriteLine($"Banka: {grupa.Banka}");
                
                Console.WriteLine("Milijunaši:");
                foreach (var milijunas in grupa.Milijunasi)
                {
                    Console.WriteLine(milijunas);
                    Console.WriteLine();
                }
            }

            var IzvjestajMilijunasa = Podaci.ListaKlijenata
                                        .Where(k => k.Stanje >= 1000000);

            Console.WriteLine();
            Console.WriteLine("Izvještaj milijunaša:");
            foreach (var klijent in IzvjestajMilijunasa)
            {
                var banka = Podaci.ListaBanki.FirstOrDefault(b => b.Simbol == klijent.Banka);
                Console.WriteLine($"Ime i prezime: {klijent.ImePrezime}, Banka: {banka?.Naziv}");
            }
        }
    }
}
