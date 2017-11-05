using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Miasto
    {
        public Miasto(Bohater bohater, Ekwipunek plecak, Bron bron, Pancerz pancerz)
        {
            int indeks = 0;
            bool wyjdz = false;

            do
            {
                Console.Clear();
                Rysuj_logo rysuj = new Rysuj_logo(15, 10);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                
                Ramka.Rysuj_ramke(0, 0, 45, 177);
                Ramka.Rysuj_ramke(140, 0, 45, 37);
                Ramka.Rysuj_ramke(0, 35, 10, 139);
                Ramka.Rysuj_ramke(144, 18, 9, 28);

                Console.SetCursorPosition(150, 15);
                Console.Write("Dostępne Lokacje:");                

                Console.SetCursorPosition(70 - (bohater.Nazwa.Length + 12)/2, 36);
                Console.Write("Statystyki: {0}", bohater.Nazwa);

                Console.SetCursorPosition(10, 38);
                Console.Write("Plecak: Poziom {0}", plecak.Poziom_plecaka);
                Console.SetCursorPosition(10, 39);
                Console.Write("Pancerz: {0} (Poziom {1})", plecak.Pancerz,plecak.Poziom_Pancerza);
                Console.SetCursorPosition(10, 40);
                Console.Write("Bron: {0} (Poziom {1})", plecak.Bron, plecak.Poziom_broni);
                Console.SetCursorPosition(10, 41);
                Console.Write("Liczba potionów: {0}/{1}", plecak.Ile_potionow, plecak.Ile_max_potionow);
                Console.SetCursorPosition(10, 42);
                Console.Write("Dostępne złoto: {0}/{1}", plecak.Kasa, plecak.Max_kasa);

                Console.SetCursorPosition(72, 38);
                Console.Write("Życie:");
                Console.SetCursorPosition(50, 39);
                Console.Write("0");
                Console.SetCursorPosition(100, 39);
                Console.Write("{0}",bohater.Max_zycie);
                Console.SetCursorPosition(116, 38);
                Console.Write("Pancerz:");
                Console.SetCursorPosition(110, 39);
                Console.Write("0");
                Console.SetCursorPosition(130, 39);
                Console.Write("{0}", pancerz.Bonus_zycia);

                Console.SetCursorPosition(84, 41);
                Console.Write("Wytrzymałość:");
                Console.SetCursorPosition(50, 42);
                Console.Write("0");
                Console.SetCursorPosition(130, 42);
                Console.Write("{0}", bohater.Max_stamina);

                Pasek_postepu.pasek(52, 39, 1, 45, 0, Convert.ToDouble(bohater.Max_zycie), Convert.ToDouble(bohater.Zycie), 1);
                Pasek_postepu.pasek(112, 39, 1, 15, 0, Convert.ToDouble(pancerz.Bonus_zycia), Convert.ToDouble(pancerz.Zycie_pancerza), 1);
                Pasek_postepu.pasek(52, 42, 1, 75, 0, Convert.ToDouble(bohater.Max_stamina), Convert.ToDouble(bohater.Stamina), 1);


                Console.SetCursorPosition(0, 0);

                Menu Menu = new Menu(5);
                Menu.UstawElement("    Warsztat Kowala      ", 0);
                Menu.UstawElement("    Warsztat Alchemika   ", 1);
                Menu.UstawElement("    Twoja Chata          ", 2);
                Menu.UstawElement("    Kopalnia             ", 3);
                Menu.UstawElement("    Wyjdź z gry          ", 4);
                Menu.Dzialaj(146, 20);
                indeks = Menu.Indeks_wybranego;

                switch (indeks)
                {
                    case 0:
                        {
                            Warsztat_Kowala warsztat_kowala = new Warsztat_Kowala(bohater, plecak, bron, pancerz);
                            break;
                        }
                    case 1:
                        {
                            Warsztat_Alchemika warsztat_alchemika = new Warsztat_Alchemika(bohater, plecak, bron, pancerz);
                            break;
                        }
                    case 2:
                        {
                            Twoja_Chata twoja_chata = new Twoja_Chata(bohater, plecak, bron, pancerz);
                            break;
                        }
                    case 3:
                        {
                            Kopalnia kopalnia = new Kopalnia(bohater, plecak, bron, pancerz);
                            break;
                        }
                    case 4:
                        {
                            wyjdz = true;
                            break;
                        }
                    default:
                        break;
                }

            } while (wyjdz == false);

        }
    }
}
