using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szpital_Projekt.Objects;

namespace Szpital_Projekt
{
    class Program
    {
        public static List<Pracownik> Pracownicy;
        public static Pracownik AktualnieZalogowany;

        static void Dadaj_Lekarza()
        {
            string imie;
            string nazwisko;
            long pesel;
            string login;
            string haslo;
            string specjalizacja;
            int numerpwz;
            Console.WriteLine("Dodawanie lekarza:");
            Console.WriteLine("Podaj Imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj Pesel:");
            pesel = 00000000000;
            while (true)
            {
                try
                {
                    pesel = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pesel musi byc liczba calkowita");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Podaj Login:");
            login = Console.ReadLine();
            Console.WriteLine("Podaj Haslo:");
            haslo = Console.ReadLine();
            Console.WriteLine("Podaj Specjalizacje:");
            specjalizacja = Console.ReadLine();
            Console.WriteLine("Podaj NumerPWZ:");
            numerpwz = 00000000000;
            while (true)
            {
                try
                {
                    numerpwz = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawidlowy format numeru PWZ");
                    Console.ResetColor();
                }
            }
            Administrator administrator = new Administrator();
            Pracownicy.Add(administrator);
            administrator.DodajOsobe(new Lekarz(imie, nazwisko, pesel, login, haslo, specjalizacja, numerpwz));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pomyślnie dodano nowego lekarza:");
            Console.ResetColor();
            Console.WriteLine(" Imie:" + imie + " Nazwisko: " + nazwisko + " Pesel: " + pesel + " Login: " + login + " Haslo: " + haslo + " Specjalizacja: " + specjalizacja + " NumerPWZ: " + numerpwz);
            Console.ReadKey();
        }
        static void Dadaj_Pielegniarke()
        {
            string imie;
            string nazwisko;
            long pesel;
            string login;
            string haslo;
            Console.WriteLine("Dodawanie pielegniarki:");
            Console.WriteLine("Podaj Imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj Pesel:");
            pesel = 00000000000;
            while (true)
            {
                try
                {
                    pesel = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pesel musi byc liczba calkowita");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Podaj Login:");
            login = Console.ReadLine();
            Console.WriteLine("Podaj Haslo:");
            haslo = Console.ReadLine();
            Administrator administrator = new Administrator();
            Pracownicy.Add(administrator);
            administrator.DodajOsobe(new Pielegniarka(imie, nazwisko, pesel, login, haslo));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pomyślnie dodano nową pielegniarke:");
            Console.ResetColor();
            Console.WriteLine("Imie: " + imie + " Nazwisko: " + nazwisko + " Pesel: " + pesel + " Login: " + login + " Haslo: " + haslo);
            Console.ReadKey();
        }
        static void Dadaj_Administratora()
        {
            string imie;
            string nazwisko;
            long pesel;
            string login;
            string haslo;
            Console.WriteLine("Dodawanie administratora:");
            Console.WriteLine("Podaj Imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj Pesel:");
            pesel = 00000000000;
            while (true)
            {
                try
                {
                    pesel = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pesel musi byc liczba calkowita");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Podaj Login:");
            login = Console.ReadLine();
            Console.WriteLine("Podaj Haslo:");
            haslo = Console.ReadLine();
            Administrator administrator = new Administrator();
            Pracownicy.Add(administrator);
            administrator.DodajOsobe(new Pielegniarka(imie, nazwisko, pesel, login, haslo));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pomyślnie dodano nowego administratora:");
            Console.ResetColor();
            Console.WriteLine("Imie: " + imie + " Nazwisko: " + nazwisko + " Pesel: " + pesel + " Login: " + login + " Haslo: " + haslo);
            Console.ReadKey();
        }
        static void Edytuj_Lekarza()
        {
            Lekarz lekarz = new Lekarz();
            string imie;
            string nazwisko;
            long pesel;
            string login;
            string haslo;
            string specjalizacja;
            int numerpwz;
            Console.WriteLine("Edytowanie Lekarza " + lekarz.Imie + " " + lekarz.Nazwisko);
            Console.WriteLine("Podaj nowe Imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nowe Nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj nowy Pesel:");
            while (true)
            {
                try
                {
                    pesel = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pesel musi byc liczba calkowita");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Podaj nowy Login:");
            login = Console.ReadLine();
            Console.WriteLine("Podaj nowe Haslo:");
            haslo = Console.ReadLine();
            Console.WriteLine("Podaj nowa Specjalizacje:");
            specjalizacja = Console.ReadLine();
            Console.WriteLine("Podaj nowy Numer PWZ:");
            while (true)
            {
                try
                {
                    numerpwz = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nieprawidlowy format numeru PWZ");
                    Console.ResetColor();
                }
            }
            imie = lekarz.Imie;
            nazwisko = lekarz.Nazwisko;
            pesel = lekarz.Pesel;
            login = lekarz.Nazwa_Urzytkownika;
            haslo = lekarz.Haslo;
            specjalizacja = lekarz.Specjalnosc;
            numerpwz = lekarz.NumerPWZ;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pomyślnie edytowano lekarza:");
            Console.ResetColor();
            Console.WriteLine(" Imie:" + imie + " Nazwisko: " + nazwisko + " Pesel: " + pesel + " Login: " + login + " Haslo: " + haslo + " Specjalizacja: " + specjalizacja + " NumerPWZ: " + numerpwz);
            Console.ReadKey();

            Console.ReadKey();
        }
        static void Edytuj_Admina()
        {
            Administrator administrator = new Administrator();
            string imie;
            string nazwisko;
            long pesel;
            string login;
            string haslo;
            Console.WriteLine("Edytowanie Administratora " + administrator.Imie + " " + administrator.Nazwisko);
            Console.WriteLine("Podaj nowe Imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nowe Nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj nowy Pesel:");
            while (true)
            {
                try
                {
                    pesel = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pesel musi byc liczba calkowita");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Podaj nowy Login:");
            login = Console.ReadLine();
            Console.WriteLine("Podaj nowe Haslo:");
            haslo = Console.ReadLine();
            imie = administrator.Imie;
            nazwisko = administrator.Nazwisko;
            pesel = administrator.Pesel;
            login = administrator.Nazwa_Urzytkownika;
            haslo = administrator.Haslo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pomyślnie edytowano administratora:");
            Console.ResetColor();
            Console.WriteLine(" Imie:" + imie + " Nazwisko: " + nazwisko + " Pesel: " + pesel + " Login: " + login + " Haslo: " + haslo);
            Console.ReadKey();
        }
        static void Edytuj_Pielegniarke()
        {
            Pielegniarka pielegniarka = new Pielegniarka();
            string imie;
            string nazwisko;
            long pesel;
            string login;
            string haslo;
            Console.WriteLine("Edytowanie Pielegniarki " + pielegniarka.Imie + " " + pielegniarka.Nazwisko);
            Console.WriteLine("Podaj nowe Imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nowe Nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj nowy Pesel:");
            while (true)
            {
                try
                {
                    pesel = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pesel musi byc liczba calkowita");
                    Console.ResetColor();
                }
            }
            Console.WriteLine("Podaj nowy Login:");
            login = Console.ReadLine();
            Console.WriteLine("Podaj nowe Haslo:");
            haslo = Console.ReadLine();
            imie = pielegniarka.Imie;
            nazwisko = pielegniarka.Nazwisko;
            pesel = pielegniarka.Pesel;
            login = pielegniarka.Nazwa_Urzytkownika;
            haslo = pielegniarka.Haslo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pomyślnie edytowano pielegniarke:");
            Console.ResetColor();
            Console.WriteLine(" Imie:" + imie + " Nazwisko: " + nazwisko + " Pesel: " + pesel + " Login: " + login + " Haslo: " + haslo);
            Console.ReadKey();
        }
        static void Admin_Edytuj()
        {
            string login_edytuj;
            Console.WriteLine("Podaj Login pracownika do edytowania");
            login_edytuj = Console.ReadLine();
            foreach (var pracownik in Pracownicy) 
            {
                if (login_edytuj == pracownik.Nazwa_Urzytkownika)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Prawidlowy login");
                    Console.ResetColor();
                    Console.WriteLine("Wybrano uzytkownika " + pracownik.Nazwa_Urzytkownika);
                    Console.ReadKey();
                    Console.Clear();
                    AktualnieZalogowany = pracownik;
                    switch (AktualnieZalogowany.Typ)
                    {
                        case "Lekarz":
                            {
                                Edytuj_Lekarza();
                                break;
                            }
                        case "Administrator":
                            {
                                Edytuj_Admina();
                                break;
                            }
                        case "Pielengniarka":
                            {
                                Edytuj_Pielegniarke();
                                break;
                            }
                        default:
                            break;
                    }

                }
            }
        }
        static void Wczytanie_Domyslnych_Uzytkownikow()
        {
            Administrator administrator = new Administrator("Dawid", "Kaczmarek", 97011325009, "dawidk", "admin");
            Pracownicy.Add(administrator);
            administrator.DodajOsobe(new Lekarz("Jan", "Stark", 91081880014, "jans", "haslo1", "kardiolog", 2566));
            administrator.DodajOsobe(new Lekarz("Dominik", "Kwiatkowski", 90021880003, "dominikk", "haslo2", "neurolog", 2566));
            administrator.DodajOsobe(new Lekarz("Jakub", "Blaszykowski", 95021745698, "jakubb", "haslo3", "laryngolog", 2566));
            administrator.DodajOsobe(new Pielegniarka("Pamela", "Skorzewska", 9045895777, "pamelas", "haslo4"));
            administrator.DodajOsobe(new Pielegniarka("Dominika", "Swoboda", 998562777, "dominikas", "haslo5"));
            administrator.DodajOsobe(new Pielegniarka("Joanna", "Hurtz", 90547777777, "joannah", "haslo6"));
        }
        static void Udane_Logowanie()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Logowanie Udane !");
            Console.ResetColor();
        }
        static void Bledny_Login()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Błędny Login");
            Console.WriteLine("Podaj poprawny login");
            Console.ResetColor();
        }
        static void Bledne_Haslo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Błędne haslo");
            Console.WriteLine("Podaj poprawne haslo");
            Console.ResetColor();
        }
        static void Login()
        {
            string login;
            string haslo;
            Console.WriteLine("Podaj Login");
            login = Console.ReadLine();
            foreach (var pracownik in Pracownicy) 
            {
                if (login == pracownik.Nazwa_Urzytkownika) 
                {
                    Console.WriteLine("Podaj Haslo");
                    haslo = Console.ReadLine();
                    while (haslo != pracownik.Haslo)
                    {
                        Bledne_Haslo();
                        haslo = Console.ReadLine();
                    }

                    AktualnieZalogowany = pracownik;
                }
            }
            Udane_Logowanie();
            Console.ReadKey();
            Console.Clear();
        }
        static void Administrator_Funkcja()
        {
            for (; ; )
            {
                Console.Clear();
                int dzialanie_administrator;
                Console.WriteLine("1. Wyswietl iste pracownikow");
                Console.WriteLine("2. Edytuj Dane");
                Console.WriteLine("3. Dodaj nowych pracownikow");
                Console.WriteLine("4. Wyjscie");
                while (true)
                {
                    try
                    {
                        dzialanie_administrator = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Prosze wybrac odpowiednia opcje!");
                        Console.ResetColor();
                    }
                }
                switch (dzialanie_administrator)
                {
                    case 1:
                        {
                            Console.WriteLine("Lista wszystkich pracownikow :");
                            foreach (var pracownik in Pracownicy)
                            {
                                Console.WriteLine(pracownik.Info_Pracownik());
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Admin_Edytuj();
                            break;
                        }
                    case 3:
                        {
                            int kogo_dodac;
                            Console.WriteLine("Kogo chcesz dodać?");
                            Console.WriteLine("1. Administratora");
                            Console.WriteLine("2. Lekarza");
                            Console.WriteLine("3. Pielegniarke");
                            while (true)
                            {
                                try
                                {
                                    kogo_dodac = int.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (Exception)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Prosze wybrac odpowiednia opcje!");
                                    Console.ResetColor();
                                }
                            }
                            switch (kogo_dodac)
                            {
                                case 1:
                                    {
                                        Dadaj_Administratora();
                                        break;
                                    }
                                case 2:
                                    {
                                        Dadaj_Lekarza();
                                        break;
                                    }
                                case 3:
                                    {
                                        Dadaj_Pielegniarke();
                                        break;
                                    }
                                default:
                                break;
                            }
                            break;
                        }
                    case 4:
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        static void Lekarz_Funkcja()
        {
            for (; ; )
            {
                Console.Clear();
                int dzialanie_lekarz;
                Console.WriteLine("1. Wyswietl liste lekarzy i pielegniarek");
                Console.WriteLine("2. Wyjscie");
                while (true)
                {
                    try
                    {
                        dzialanie_lekarz = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Prosze wybrac odpowiednia opcje!");
                        Console.ResetColor();
                    }
                }
                switch (dzialanie_lekarz)
                {
                    case 1:
                        {
                            Console.WriteLine("Lista Lekarzy i pielegniarek");
                            Lekarz lekarz = new Lekarz();
                            foreach (var lekarz1 in lekarz.Lekarze)
                            {
                                Console.WriteLine(lekarz1.Info_Lekarz());
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        static void Pielegniarka_Funkcja()
        {
            for (; ; )
            {
                Console.Clear();
                int dzialanie_pielegniarka;
                Console.WriteLine("1. Wyswietl iste lekarzy i pielegniarek");
                Console.WriteLine("2. Wyjscie");
                while (true)
                {
                    try
                    {
                        dzialanie_pielegniarka = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Prosze wybrac odpowiednia opcje!");
                        Console.ResetColor();
                    }
                }
                switch (dzialanie_pielegniarka)
                {
                    case 1:
                        {
                            foreach (var pracownik in Pracownicy)
                            {
                                if (pracownik.Typ == "Lekarz" || pracownik.Typ == "Pielengniarka")
                                {
                                    Console.WriteLine();
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        static void App()
        {
            Login();

            switch (AktualnieZalogowany.Typ)
            {
                case "Lekarz":
                    {
                        Lekarz_Funkcja();
                        break;
                    }
                case "Administrator":
                    {
                        Administrator_Funkcja();
                        break;
                    }
                case "Pielengniarka":
                    {
                        Pielegniarka_Funkcja();
                        break;
                    }
                default:
                    break;
            }

        }

        static void Main(string[] args) // Dawid Kaczmarek K21 
        {
            Pracownicy = new List<Pracownik>();
            Wczytanie_Domyslnych_Uzytkownikow();
            App();
        }
    }
}
