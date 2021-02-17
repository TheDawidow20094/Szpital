using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szpital_Projekt.Objects
{
    class Pielegniarka:Pracownik
    {
        public Pielegniarka(string imie, string nazwisko, long pesel, string nazwa_uzytkownika, string haslo)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pesel = pesel;
            this.Nazwa_Urzytkownika = nazwa_uzytkownika;
            this.Haslo = haslo;
            this.Typ = "Pielengniarka";
        }
        public Pielegniarka()
        {

        }

        public string Info_Pielegniarka()
        {
            string wynik = ("Imie: " + Imie + " Nazwisko: " + Nazwisko + " Pesel: " + Pesel);
            return wynik;
        }
    }
}
