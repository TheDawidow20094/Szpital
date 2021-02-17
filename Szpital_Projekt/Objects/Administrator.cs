using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szpital_Projekt.Objects
{
    class Administrator:Pracownik
    {
        public Administrator(string imie, string nazwisko, long pesel, string nazwa_uzytkownika, string haslo)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Pesel = pesel;
            this.Nazwa_Urzytkownika = nazwa_uzytkownika;
            this.Haslo = haslo;
            this.Typ = "Administrator";
        }
        public Administrator()
        {
        }
        public List<Pracownik> Pracownicy { get; set; }

        public void DodajOsobe(Pracownik pracownik)
        {
            Szpital_Projekt.Program.Pracownicy.Add(pracownik);
        }
      
    }
}
