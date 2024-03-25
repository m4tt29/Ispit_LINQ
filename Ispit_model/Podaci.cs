using Ispit_model.Klase;
using System.Collections.Generic;

namespace Ispit_model
{
    public class Podaci : Banka
    {
         public static List<Banka> ListaBanki = new List<Banka>()
        {
            new Banka() {Simbol = "ZABA", Naziv = "Zagrebačka banka"},
            new Banka() {Simbol = "PBZ", Naziv = "Privredna banka Zagreb"},
            new Banka() {Simbol = "Erste", Naziv = "Erste&Steiermärkische Bank"}
        };

         public static List<Klijent> ListaKlijenata = new List<Klijent>()
        {
            new Klijent() { ImePrezime = "Mirko Miočić", Stanje = 4000, Banka = "ZABA" },
            new Klijent() { ImePrezime = "Rene Bitorajac", Stanje = 1000000, Banka = "PBZ" },
            new Klijent() { ImePrezime = "Josip Jelačić", Stanje = 2100, Banka = "ZABA" },
            new Klijent() { ImePrezime = "Johhny Depp", Stanje = 1000000, Banka = "Erste" },
            new Klijent() { ImePrezime = "Janko Kozlić", Stanje = 1200, Banka = "ZABA" },
            new Klijent() { ImePrezime = "Marko Marulić", Stanje = 9050, Banka = "ZABA" },
            new Klijent() { ImePrezime = "Krešimir Gavran", Stanje = 1000000, Banka = "ZABA" },
            new Klijent() { ImePrezime = "Nikola Tesla", Stanje = 900, Banka = "Erste" },
            new Klijent() { ImePrezime = "Kristijan Frlek", Stanje = 110000, Banka = "PBZ" },
            new Klijent() { ImePrezime = "Martina Kovačević", Stanje = 105020, Banka = "ZABA" },
            new Klijent() { ImePrezime = "Lucija Toč", Stanje = 300, Banka = "PBZ" },
        };
    }
}
