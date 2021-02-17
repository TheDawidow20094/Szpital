using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szpital_Projekt.Objects
{
    class Lekarz:Pracownik
    {
        public Lekarz(string imie, string nazwisko, long pesel, string nazwa_uzytkownika, string haslo,string specjalnosc,int numerpwz)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pesel = pesel;
            this.Nazwa_Urzytkownika = nazwa_uzytkownika;
            this.Haslo = haslo;
            this.Specjalnosc = specjalnosc;
            this.NumerPWZ = numerpwz;
            this.Typ = "Lekarz";
            Lekarze = new List<Lekarz>();  
        }
        public Lekarz()
        {
            
        }

        public string Specjalnosc { get; set; }
        public int NumerPWZ { get; set; }
        public List<Lekarz> Lekarze { get; set; }

        public string Info_Lekarz()
        {
            string wynik = ("Imie: " + Imie + " Nazwisko: " + Nazwisko + " Pesel: " + Pesel + " Specjalizacja: " + Specjalnosc + " Numer PWZ: " + NumerPWZ);
            return wynik;
        }
    }

}
