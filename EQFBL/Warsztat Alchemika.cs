using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Warsztat_Alchemika
    {
        public Warsztat_Alchemika(Bohater bohater, Ekwipunek plecak, Bron bron, Pancerz pancerz)
        {
            int indeks = 0;
            bool wyjdz = false;

            Console.SetCursorPosition(145, 31);
            Console.Write("Tu możesz kupic mikstury");
            Console.SetCursorPosition(145, 32);
            Console.Write("życia i w sumie tyle :D");
            Console.SetCursorPosition(145, 33);
            Console.Write("takie tam potionki...");
            Console.SetCursorPosition(145, 34);
            Console.Write("czerwone");
            Console.SetCursorPosition(145, 36);
            Console.Write("Uwaga:");
            Console.SetCursorPosition(145, 37);
            Console.Write("Spryciarz Ci je sprzeda");
            Console.SetCursorPosition(145, 38);
            Console.Write("nawet jak nie będziesz");
            Console.SetCursorPosition(145, 39);
            Console.Write("miał na nie miejsca");


            Ramka.Rysuj_ramke(90, 18, 17, 47);


            do
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.SetCursorPosition(91, 19 + i);
                    Console.WriteLine("                                               ");
                }

                Console.SetCursorPosition(97, 22);
                Console.Write("Witaj, w czym mogę Ci dzisiaj pomóc?");

                Console.SetCursorPosition(92, 32);
                Console.Write("Złoto:");
                Console.SetCursorPosition(92, 33);
                Console.Write(plecak.Kasa);
                Console.SetCursorPosition(100, 32);
                Console.Write("Cena mikstury:");
                Console.SetCursorPosition(100, 33);
                Console.Write("20");
                Console.SetCursorPosition(120, 32);
                Console.Write("Ilość mikstur");
                Console.SetCursorPosition(120, 33);
                Console.Write("{0}/{1}", plecak.Ile_potionow, plecak.Ile_max_potionow);

                Ramka.Rysuj_ramke(105, 24, 6, 18);
                Menu menu = new Menu(2);
                menu.UstawElement("  Kup Mikstury  ", 0);
                menu.UstawElement("  Bywaj         ", 1);
                menu.Dzialaj(107, 26);
                indeks = menu.Indeks_wybranego;

                switch (indeks)
                {
                    case 0:
                        {
                            if (plecak.Kasa >= 20)
                            {
                                plecak.Wydatek(20);
                                plecak.plus_potion();
                            }
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
