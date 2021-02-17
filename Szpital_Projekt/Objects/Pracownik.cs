using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szpital_Projekt.Objects
{
    class Pracownik
    {
        public Pracownik(string imie,string nazwisko,long pesel,string nazwa_uzytkownika,string haslo)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pesel = pesel;
            this.Nazwa_Urzytkownika = nazwa_uzytkownika;
            this.Haslo = haslo;
        }
        public Pracownik()
        {

        }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public long Pesel { get; set; }
        public string Nazwa_Urzytkownika { get; set; }
        public string Haslo { get; set; }
        public string Typ { get; set; }

        public string Info_Pracownik()
        {
            string wynik = ("Imie: " + Imie + " Nazwisko: " + Nazwisko + " Pesel: " + Pesel);
            return wynik;
        }
    }
}
