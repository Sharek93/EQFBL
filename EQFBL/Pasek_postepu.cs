using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Pasek_postepu
    {
        public static void pasek(int x = 0, int y = 0, int wysokosc = 1, int szerokosc = 30, int wart_pocz = 0, double wart_konc = 100, double wartosc = 50, byte czy_ramka = 1)
        {
            double postep;
            double ile = 1;

            //Zabezpieczenia

            if (x < 0 || y < 0) { x = 0; y = 0; }
            if (wysokosc < 1) { wysokosc = 1; }
            if (szerokosc < 5) { szerokosc = 5; }
            if (wart_konc <= wart_pocz) { wart_konc = wart_pocz + 100; }
            if (wartosc < 0) { wartosc = 0; }
            if (wartosc > wart_konc) { wartosc = wart_konc; }
            if (czy_ramka > 2 || czy_ramka < 0) { czy_ramka = 0; }
            if (czy_ramka == 1) { wysokosc = 1; }

            wysokosc = wysokosc + 2;

            //Rysowanie ramki

            if (czy_ramka == 2)
            {


                Console.SetCursorPosition(x, y);
                for (int i = 0; i <= wysokosc; i++)
                {
                    Console.Write("|");
                    Console.SetCursorPosition(x, y + i);
                }

                Console.SetCursorPosition(x + szerokosc + 1, y);
                for (int i = 0; i <= wysokosc; i++)
                {
                    Console.Write("|");
                    Console.SetCursorPosition(x + szerokosc + 1, y + i);
                }

                Console.SetCursorPosition(x + 1, y);
                for (int i = 0; i <= szerokosc; i++)
                {
                    Console.Write("=");
                    Console.SetCursorPosition(x + i + 1, y);
                }

                Console.SetCursorPosition(x + 1, y + wysokosc - 1);
                for (int i = 0; i <= szerokosc; i++)
                {
                    Console.Write("=");
                    Console.SetCursorPosition(x + i + 1, y + wysokosc - 1);
                }

                //Rysowanie narożników

                Console.SetCursorPosition(x, y);
                Console.Write("#");
                Console.SetCursorPosition(x + szerokosc + 1, y);
                Console.Write("#");
                Console.SetCursorPosition(x + szerokosc + 1, y + wysokosc - 1);
                Console.Write("#");
                Console.SetCursorPosition(x, y + wysokosc - 1);
                Console.Write("#");
            }
            else if (czy_ramka == 1)
            {
                y--;
                Console.SetCursorPosition(x, y + 1);
                Console.Write("[");
                Console.SetCursorPosition(x + 1 + szerokosc, y + 1);
                Console.Write("]");
            }
            else
            {
                x--;
                y--;
            }

            //Pasek Postepu

            postep = wart_konc / szerokosc;

            ile = wartosc / postep;
            ile = Math.Round(ile);

            Console.SetCursorPosition(x + 1, y + 1);

            for (int i = 0; i < wysokosc - 2; i++)
            {
                for (int j = 0; j <= szerokosc - 1; j++)
                {
                    Console.SetCursorPosition(x + 1 + j, y + 1 + i);
                    Console.Write(" ");
                }
            }

            Console.SetCursorPosition(x + 1, y + 1);

            for (int i = 0; i < wysokosc - 2; i++)
            {
                for (int j = 0; j < ile; j++)
                {
                    Console.SetCursorPosition(x + 1 + j, y + 1 + i);
                    Console.Write("#");

                }
            }

            //Ustawienie kursora pod wszytkim

            if (x < 0) { x = 0; }
            Console.SetCursorPosition(x, y + wysokosc);

        }
    }
}
