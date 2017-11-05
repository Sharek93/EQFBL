using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Kopalnia
    {
        public Kopalnia(Bohater bohater, Ekwipunek plecak, Bron bron, Pancerz pancerz)
        {
            int indeks = 0;
            bool wyjdz = false;

            Console.SetCursorPosition(145, 27);
            Console.Write("Tu zaczyna się frajda.");
            Console.SetCursorPosition(145, 28);
            Console.Write("Ogólnie to wchodzisz i bijesz");
            Console.SetCursorPosition(145, 29);
            Console.Write("wszystko co jest przed Tobą");
            Console.SetCursorPosition(145, 30);
            Console.Write("I jeszcze dostajesz za to Złoto!");
            Console.SetCursorPosition(145, 31);
            Console.Write("Pamiętaj, im głębiej tym ciemniej");
            Console.SetCursorPosition(145, 32);
            Console.Write("i trudniej.");
            Console.SetCursorPosition(145, 33);
            Console.Write("Ale za to nagrody lepsze");
            Console.SetCursorPosition(145, 35);
            Console.Write("Uwaga:");
            Console.SetCursorPosition(145, 36);
            Console.Write("jak umrzesz to utracisz wszystko");
            Console.SetCursorPosition(145, 37);
            Console.Write("co udało Ci się zebrać");
            Console.SetCursorPosition(145, 38);
            Console.Write("Spokojnie, dzielni medycy");
            Console.SetCursorPosition(145, 39);
            Console.Write("wejdą po Ciebie i zabiorą do");
            Console.SetCursorPosition(145, 40);
            Console.Write("Kliniki. Oczywiście jeżeli");
            Console.SetCursorPosition(145, 41);
            Console.Write("zdążą zanim Cię potwory");
            Console.SetCursorPosition(145, 42);
            Console.Write("rozszarpią. Powodzenia!");

            Ramka.Rysuj_ramke(90, 18, 17, 47);

            do
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.SetCursorPosition(91, 19 + i);
                    Console.WriteLine("                                               ");
                }

                Console.SetCursorPosition(105, 22);
                Console.Write("Wchodzisz do kopalni?");

                Ramka.Rysuj_ramke(108, 24, 6, 9);
                Menu menu = new Menu(2);
                menu.UstawElement(" Tak ", 0);
                menu.UstawElement(" Nie ", 1);
                menu.Dzialaj(111, 26);
                indeks = menu.Indeks_wybranego;

                switch (indeks)
                {
                    case 0:
                        {
                            Walka walka = new Walka(bohater, plecak, bron, pancerz);
                            wyjdz = true;
                            break;
                        }
                    case 1:
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
