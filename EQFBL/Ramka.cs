using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Ramka
    {
        public static void Rysuj_ramke(int x, int y, int wysokosc, int szerokosc)
        {
            //Rysowanie ramki

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
    }
}
