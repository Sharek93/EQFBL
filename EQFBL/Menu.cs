using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Menu
    {
        int indeksWybranego;
        int liczbaElementow;
        string[] elementy;

        public Menu(int liczbaElementow)
        {
            elementy = new string[liczbaElementow];
            this.liczbaElementow = liczbaElementow;
        }

        public void UstawElement(string NazwaElementu, int indeks)
        {
            if (indeks >= 0 && indeks < liczbaElementow)
            {
                elementy[indeks] = NazwaElementu;
            }
        }

        public int Indeks_wybranego
        {
            get { return indeksWybranego; }
        }

        public void Dzialaj(int x, int y)
        {
            ConsoleKeyInfo klawisz = new ConsoleKeyInfo();

            while (klawisz.Key != ConsoleKey.Enter && klawisz.Key != ConsoleKey.Escape)
            {
                Wyswietl(x,y);
                klawisz = Console.ReadKey();
                switch (klawisz.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (indeksWybranego < liczbaElementow - 1)
                        {
                            indeksWybranego++;
                        }
                        else
                        {
                            indeksWybranego = 0;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (indeksWybranego > 0)
                        {
                            indeksWybranego--;
                        }
                        else
                        {
                            indeksWybranego = liczbaElementow - 1;
                        }
                        break;

                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        break;
                }
            }
        }
        private void Wyswietl(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < liczbaElementow; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                if (indeksWybranego == i)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(elementy[i]);
                Console.SetCursorPosition(x, y + i);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
