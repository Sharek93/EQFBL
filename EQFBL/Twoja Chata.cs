using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Twoja_Chata
    {
        public Twoja_Chata(Bohater bohater, Ekwipunek plecak, Bron bron, Pancerz pancerz)
        {
            int indeks = 0;
            bool wyjdz = false;

            Console.SetCursorPosition(145, 31);
            Console.Write("Tu możesz odpocząc");
            Console.SetCursorPosition(145, 32);
            Console.Write("zregenerować się przed");
            Console.SetCursorPosition(145, 33);
            Console.Write("następną walką. I ma tu");
            Console.SetCursorPosition(145, 34);
            Console.Write("na myśli życie ");
            Console.SetCursorPosition(145, 35);
            Console.Write("i wytrzymałość.");
            Console.SetCursorPosition(145, 36);
            Console.Write("Ot tak za darmo!. :D");
            Console.SetCursorPosition(145, 37);
            Console.Write("A i możesz tu zapisać grę");
            Console.SetCursorPosition(145, 38);
            Console.Write("jak coś.");

            Ramka.Rysuj_ramke(90, 18, 17, 47);

            bohater.Regeneracja_zycia(1000);
            bohater.Regeneracja_staminy(1000);

            do
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.SetCursorPosition(91, 19 + i);
                    Console.WriteLine("                                               ");
                }

                Console.SetCursorPosition(105, 22);
                Console.Write("Chcesz Zapisać grę");

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
                            Zapisz zapisz = new Zapisz(bohater, plecak);
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
