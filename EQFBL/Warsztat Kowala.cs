using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Warsztat_Kowala
    {
        public Warsztat_Kowala(Bohater bohater, Ekwipunek plecak, Bron bron, Pancerz pancerz)
        {
            int indeks = 0;
            bool wyjdz = false;

            Console.SetCursorPosition(145, 31);
            Console.Write("Tu możesz naprawić pancerz");
            Console.SetCursorPosition(145, 32);
            Console.Write("ulepszyć swój plecak, broń");
            Console.SetCursorPosition(145, 33);
            Console.Write("oraz pancerz");

            Console.SetCursorPosition(145, 35);
            Console.Write("Podpowiedz:");
            Console.SetCursorPosition(145, 36);
            Console.Write("Twój pancerz naprawi się");
            Console.SetCursorPosition(145, 37);
            Console.Write("sam jak tylko tu wejdziesz");

            Console.SetCursorPosition(145, 39);
            Console.Write("Uwaga:");
            Console.SetCursorPosition(145, 40);
            Console.Write("Zmiana wyposażenia spowoduje");
            Console.SetCursorPosition(145, 41);
            Console.Write("utratę poziomu");

            Ramka.Rysuj_ramke(90, 18, 17, 47);

            pancerz.Naprawa_pancerza();

            do
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.SetCursorPosition(91, 19 + i);
                    Console.WriteLine("                                               ");
                }

                Console.SetCursorPosition(97, 22);
                Console.Write("Witaj, w czym mogę Ci dzisiaj pomóc?");

                Ramka.Rysuj_ramke(101, 24, 7, 21);
                Menu menu = new Menu(3);
                menu.UstawElement(" Ulepsz Rynsztunek ", 0);
                menu.UstawElement(" Zmień Rynsztunek  ", 1);
                menu.UstawElement(" Bywaj             ", 2);
                menu.Dzialaj(103, 26);
                indeks = menu.Indeks_wybranego;

                switch (indeks)
                {
                    case 0:
                        {
                            #region Case 0
                            do
                            {
                                for (int i = 0; i < 15; i++)
                                {
                                    Console.SetCursorPosition(91, 19 + i);
                                    Console.WriteLine("                                               ");
                                }

                                Console.SetCursorPosition(95, 20);
                                Console.Write("Twój Plecak: Poziom {0}", plecak.Poziom_plecaka);
                                Console.SetCursorPosition(95, 22);
                                Console.Write("Broń: {0} Poziom {1}", plecak.Bron, plecak.Poziom_broni);
                                Console.SetCursorPosition(95, 23);
                                Console.Write("Obrażenia: {0}", bron.Obrazenia_goly);
                                Console.SetCursorPosition(95, 24);
                                Console.Write("Obrażenia przy gardzie: {0}", bron.Obrazenia_zasloniety);
                                Console.SetCursorPosition(95, 25);
                                Console.Write("Zmęcznie: {0}", bron.Zmeczenie);
                                Console.SetCursorPosition(95, 26);
                                Console.Write("Pancerz: {0} Poziom {1}", plecak.Pancerz, plecak.Poziom_Pancerza);
                                Console.SetCursorPosition(95, 27);
                                Console.Write("Bonus życia: {0}", pancerz.Bonus_zycia);
                                Console.SetCursorPosition(95, 28);
                                Console.Write("Bonus Wytrzym.: {0}", pancerz.Bonus_staminy);
                                Console.SetCursorPosition(95, 30);
                                Console.Write("Złoto: {0}", plecak.Kasa);

                                Console.SetCursorPosition(115, 29);
                                Console.Write("Co chcesz ulepszyć?");
                                Menu menu2 = new Menu(4);
                                menu2.UstawElement(" Broń     " + plecak.Poziom_broni * 10, 0);
                                menu2.UstawElement(" Pancerz  " + plecak.Poziom_Pancerza * 10, 1);
                                menu2.UstawElement(" Plecak   " + plecak.Poziom_plecaka * 50, 2);
                                menu2.UstawElement(" Cofnij   ", 3);
                                menu2.Dzialaj(118, 30);
                                indeks = menu2.Indeks_wybranego;

                                switch (indeks)
                                {
                                    case 0:
                                        {
                                            if (plecak.Kasa >= plecak.Poziom_broni * 10)
                                            {
                                                plecak.Wydatek(plecak.Poziom_broni * 10);
                                                plecak.Poziom_broni = plecak.Poziom_broni + 1;
                                                bron.Przelicz_bron(plecak.Bron, plecak.Poziom_broni);
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(93, 32);
                                                Console.Write("Brakuje Ci {0} złota", plecak.Poziom_broni * 10 - plecak.Kasa);
                                                System.Threading.Thread.Sleep(1000);
                                            }
                                            break;
                                        }
                                    case 1:
                                        {
                                            if (plecak.Kasa >= plecak.Poziom_Pancerza * 10)
                                            {
                                                plecak.Wydatek(plecak.Poziom_Pancerza * 10);
                                                plecak.Poziom_Pancerza = plecak.Poziom_Pancerza + 1;
                                                pancerz.Przelicz_pancerz(plecak.Pancerz, plecak.Poziom_Pancerza);
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(93, 32);
                                                Console.Write("Brakuje Ci {0} złota", plecak.Poziom_Pancerza * 10 - plecak.Kasa);
                                                System.Threading.Thread.Sleep(1000);
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            if (plecak.Kasa >= plecak.Poziom_plecaka * 50)
                                            {
                                                plecak.Wydatek(plecak.Poziom_plecaka * 50);
                                                plecak.Poziom_plecaka = plecak.Poziom_plecaka + 1;
                                                plecak.Przelicz_plecak(plecak.Poziom_plecaka);
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(93, 32);
                                                Console.Write("Brakuje Ci {0} złota", plecak.Poziom_plecaka * 50 - plecak.Kasa);
                                                System.Threading.Thread.Sleep(1000);
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            wyjdz = true;
                                            break;
                                        }
                                    default:
                                        break;
                                }
                            } while (wyjdz == false);
                            wyjdz = false;
                            break; 
                            #endregion
                        }
                    case 1:
                        {
                            #region Case 1
                            for (int i = 0; i < 15; i++)
                            {
                                Console.SetCursorPosition(91, 19 + i);
                                Console.WriteLine("                                               ");
                            }
                            Console.SetCursorPosition(95, 20);
                            Console.Write("Dostępny asortyment:");
                            Console.SetCursorPosition(95, 22);
                            Console.Write("Broń:");
                            string[] temp = new string[bohater.Zwroc_ograniczenia_broni.Length];
                            bohater.Zwroc_ograniczenia_broni.CopyTo(temp, 0);
                            for (int i = 0; i < bohater.Zwroc_ograniczenia_broni.Length; i++)
                            {
                                Console.SetCursorPosition(95, 24 + i);
                                Console.Write("{0}. {1}", i + 1, temp[i]);
                            }
                            Console.SetCursorPosition(95, 28);
                            Console.Write("Pancerz:");
                            string[] temp2 = new string[bohater.Zwroc_ograniczenia_pancerzy.Length];
                            bohater.Zwroc_ograniczenia_pancerzy.CopyTo(temp2, 0);
                            for (int i = 0; i < bohater.Zwroc_ograniczenia_pancerzy.Length; i++)
                            {
                                Console.SetCursorPosition(95, 30 + i);
                                Console.Write("{0}. {1}", i + 1, temp2[i]);
                            }

                            Console.SetCursorPosition(113, 22);
                            Console.Write("Co chcesz wymienić?");
                            Menu menu2 = new Menu(2);
                            menu2.UstawElement(" Broń     ", 0);
                            menu2.UstawElement(" Pancerz  ", 1);
                            menu2.Dzialaj(116, 24);
                            indeks = menu2.Indeks_wybranego;

                            switch (indeks)
                            {
                                case 0:
                                    {
                                        Console.SetCursorPosition(113, 27);
                                        Console.Write("Wiebieraj:");
                                        Menu menu3 = new Menu(bohater.Zwroc_ograniczenia_broni.Length);
                                        for (int i = 0; i < bohater.Zwroc_ograniczenia_broni.Length; i++)
                                        {
                                            menu3.UstawElement(" " + temp[i] + " ", i);
                                        }
                                        menu3.Dzialaj(116, 29);
                                        indeks = menu3.Indeks_wybranego;
                                        switch (indeks)
                                        {
                                            case 0:
                                                {
                                                    plecak.Bron = temp[0];
                                                    plecak.Poziom_broni = 1;
                                                    bron.Przelicz_bron(temp[0], 1);
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    plecak.Bron = temp[1];
                                                    plecak.Poziom_broni = 1;
                                                    bron.Przelicz_bron(temp[1], 1);
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }
                                            default:
                                                break;
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        Console.SetCursorPosition(113, 27);
                                        Console.Write("Wiebieraj:");
                                        Menu menu3 = new Menu(bohater.Zwroc_ograniczenia_pancerzy.Length);
                                        for (int i = 0; i < bohater.Zwroc_ograniczenia_pancerzy.Length; i++)
                                        {
                                            menu3.UstawElement(" " + temp2[i] + " ", i);
                                        }
                                        menu3.Dzialaj(116, 29);
                                        indeks = menu3.Indeks_wybranego;
                                        switch (indeks)
                                        {
                                            case 0:
                                                {
                                                    plecak.Pancerz = temp2[0];
                                                    plecak.Poziom_Pancerza = 1;
                                                    pancerz.Przelicz_pancerz(temp2[0], 1);
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    plecak.Pancerz = temp2[1];
                                                    plecak.Poziom_Pancerza = 1;
                                                    pancerz.Przelicz_pancerz(temp2[1], 1);
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    break;
                                                }
                                            default:
                                                break;
                                        }
                                        break;
                                    }
                                default:
                                    break;
                            }

                            break; 
                            #endregion
                        }
                    case 2:
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
