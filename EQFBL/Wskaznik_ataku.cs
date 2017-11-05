using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Wskaznik_ataku
    {

        public static void Wskazanie_Gracza(string kierunek_ataku, string kierunek_obrony, int x, int y, int wielkosc)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            //zabezpieczenia

            if (wielkosc > x) { wielkosc = x - 1; }
            if (wielkosc > y) { wielkosc = y - 1; }

            //Rysowanie rakmi

            Console.SetCursorPosition(x, y);
            Console.Write("O");

            for (int i = 1; i <= wielkosc; i++)
            {
                Console.SetCursorPosition(x + i, y + i);
                Console.Write("\\");
                Console.SetCursorPosition(x - i, y + i);
                Console.Write("/");
                Console.SetCursorPosition(x - i, y - i);
                Console.Write("\\");
                Console.SetCursorPosition(x + i, y - i);
                Console.Write("/");
            }



            // Kierunek obrony
            #region Kierunek Obrony
            switch (kierunek_obrony)
            {
                case "góra":
                    {
                        for (int i = 1; i <= wielkosc; i++)
                        {
                            if (i == 1)
                            {
                                Console.SetCursorPosition(x, y - 1);
                                Console.Write("v");
                            }
                            else
                            {
                                for (int j = 1; j <= i * 2 - 1; j++)
                                {
                                    Console.SetCursorPosition(x - i + j, y - i);
                                    Console.Write("#");
                                }
                            }
                        }
                        break;
                    }
                case "dół":
                    {
                        for (int i = 1; i <= wielkosc; i++)
                        {
                            if (i == 1)
                            {
                                Console.SetCursorPosition(x, y + 1);
                                Console.Write("^");
                            }
                            else
                            {
                                for (int j = 1; j <= i * 2 - 1; j++)
                                {
                                    Console.SetCursorPosition(x - i + j, y + i);
                                    Console.Write("#");
                                }
                            }
                        }
                        break;
                    }
                case "lewo":
                    {
                        for (int i = 1; i <= wielkosc; i++)
                        {
                            if (i == 1)
                            {
                                Console.SetCursorPosition(x - 1, y);
                                Console.Write(">");
                            }
                            else
                            {
                                for (int j = 1; j <= i * 2 - 1; j++)
                                {
                                    Console.SetCursorPosition(x - i, y - i + j);
                                    Console.Write("#");
                                }
                            }
                        }
                        break;
                    }
                case "prawo":
                    {
                        for (int i = 1; i <= wielkosc; i++)
                        {
                            if (i == 1)
                            {
                                Console.SetCursorPosition(x + 1, y);
                                Console.Write("<");
                            }
                            else
                            {
                                for (int j = 1; j <= i * 2 - 1; j++)
                                {
                                    Console.SetCursorPosition(x + i, y - i + j);
                                    Console.Write("#");
                                }
                            }
                        }
                        break;
                    }
            }
            #endregion

            //Kierunek ataku
            #region Kierunek Ataku
            switch (kierunek_ataku)
            {
                case "góra":
                    {
                        for (int i = 0; i < wielkosc * 2 + 1; i++)
                        {
                            Console.SetCursorPosition(x - wielkosc + i, y - wielkosc - 1);
                            Console.Write("v");
                        }
                        break;
                    }
                case "dół":
                    {
                        for (int i = 0; i < wielkosc * 2 + 1; i++)
                        {
                            Console.SetCursorPosition(x - wielkosc + i, y + wielkosc + 1);
                            Console.Write("^");
                        }
                        break;
                    }
                case "lewo":
                    {
                        for (int i = 0; i < wielkosc * 2 + 1; i++)
                        {
                            Console.SetCursorPosition(x - wielkosc - 1, y - wielkosc + i);
                            Console.Write(">");
                        }
                        break;
                    }
                case "prawo":
                    {
                        for (int i = 0; i < wielkosc * 2 + 1; i++)
                        {
                            Console.SetCursorPosition(x + wielkosc + 1, y - wielkosc + i);
                            Console.Write("<");
                        }
                        break;
                    }
            }
            #endregion

        }

        public static void Wskazanie_potwora(string kierunek_ataku, string kierunek_bez_obrony, int x, int y, int wielkosc)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            //zabezpieczenia

            if (wielkosc > x) { wielkosc = x - 1; }
            if (wielkosc > y) { wielkosc = y - 1; }

            //Rysowanie rakmi

            Console.SetCursorPosition(x, y);
            Console.Write("O");

            for (int i = 1; i <= wielkosc; i++)
            {
                Console.SetCursorPosition(x + i, y + i);
                Console.Write("\\");
                Console.SetCursorPosition(x - i, y + i);
                Console.Write("/");
                Console.SetCursorPosition(x - i, y - i);
                Console.Write("\\");
                Console.SetCursorPosition(x + i, y - i);
                Console.Write("/");
            }

            // Zapełnianie ramki
            #region Zapełnianie_Ramki
            for (int i = 1; i <= wielkosc; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(x, y - 1);
                    Console.Write("v");
                }
                else
                {
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.SetCursorPosition(x - i + j, y - i);
                        Console.Write("#");
                    }
                }
            }
            for (int i = 1; i <= wielkosc; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("^");
                }
                else
                {
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.SetCursorPosition(x - i + j, y + i);
                        Console.Write("#");
                    }
                }
            }

            for (int i = 1; i <= wielkosc; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(x - 1, y);
                    Console.Write(">");
                }
                else
                {
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.SetCursorPosition(x - i, y - i + j);
                        Console.Write("#");
                    }
                }
            }
            for (int i = 1; i <= wielkosc; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(x + 1, y);
                    Console.Write("<");
                }
                else
                {
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.SetCursorPosition(x + i, y - i + j);
                        Console.Write("#");
                    }
                }
            }
            #endregion

            #region Kierunek Ataku
            switch (kierunek_ataku)
            {
                case "góra":
                    {
                        for (int i = 0; i < wielkosc * 2 + 1; i++)
                        {
                            Console.SetCursorPosition(x - wielkosc + i, y - wielkosc - 1);
                            Console.Write("v");
                        }
                        break;
                    }
                case "dół":
                    {
                        for (int i = 0; i < wielkosc * 2 + 1; i++)
                        {
                            Console.SetCursorPosition(x - wielkosc + i, y + wielkosc + 1);
                            Console.Write("^");
                        }
                        break;
                    }
                case "lewo":
                    {
                        for (int i = 0; i < wielkosc * 2 + 1; i++)
                        {
                            Console.SetCursorPosition(x - wielkosc - 1, y - wielkosc + i);
                            Console.Write(">");
                        }
                        break;
                    }
                case "prawo":
                    {
                        for (int i = 0; i < wielkosc * 2 + 1; i++)
                        {
                            Console.SetCursorPosition(x + wielkosc + 1, y - wielkosc + i);
                            Console.Write("<");
                        }
                        break;
                    }
            }
            #endregion

            // Kierunek obrony
            #region Kierunek bez Obrony
            switch (kierunek_bez_obrony)
            {
                case "góra":
                    {
                        for (int i = 1; i <= wielkosc; i++)
                        {
                            if (i == 1)
                            {
                                Console.SetCursorPosition(x, y - 1);
                                Console.Write(" ");
                            }
                            else
                            {
                                for (int j = 1; j <= i * 2 - 1; j++)
                                {
                                    Console.SetCursorPosition(x - i + j, y - i);
                                    Console.Write(" ");
                                }
                            }
                        }
                        break;
                    }
                case "dół":
                    {
                        for (int i = 1; i <= wielkosc; i++)
                        {
                            if (i == 1)
                            {
                                Console.SetCursorPosition(x, y + 1);
                                Console.Write(" ");
                            }
                            else
                            {
                                for (int j = 1; j <= i * 2 - 1; j++)
                                {
                                    Console.SetCursorPosition(x - i + j, y + i);
                                    Console.Write(" ");
                                }
                            }
                        }
                        break;
                    }
                case "lewo":
                    {
                        for (int i = 1; i <= wielkosc; i++)
                        {
                            if (i == 1)
                            {
                                Console.SetCursorPosition(x - 1, y);
                                Console.Write(" ");
                            }
                            else
                            {
                                for (int j = 1; j <= i * 2 - 1; j++)
                                {
                                    Console.SetCursorPosition(x - i, y - i + j);
                                    Console.Write(" ");
                                }
                            }
                        }
                        break;
                    }
                case "prawo":
                    {
                        for (int i = 1; i <= wielkosc; i++)
                        {
                            if (i == 1)
                            {
                                Console.SetCursorPosition(x + 1, y);
                                Console.Write(" ");
                            }
                            else
                            {
                                for (int j = 1; j <= i * 2 - 1; j++)
                                {
                                    Console.SetCursorPosition(x + i, y - i + j);
                                    Console.Write(" ");
                                }
                            }
                        }
                        break;
                    }
            }
            #endregion

        }

        public static void czyszczenie_wskazania_wewn_gracza(int x, int y, int wielkosc)
        {
            for (int i = 1; i <= wielkosc; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(x, y - 1);
                    Console.Write(" ");
                }
                else
                {
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.SetCursorPosition(x - i + j, y - i);
                        Console.Write(" ");
                    }
                }
            }
            for (int i = 1; i <= wielkosc; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write(" ");
                }
                else
                {
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.SetCursorPosition(x - i + j, y + i);
                        Console.Write(" ");
                    }
                }
            }
            for (int i = 1; i <= wielkosc; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(x - 1, y);
                    Console.Write(" ");
                }
                else
                {
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.SetCursorPosition(x - i, y - i + j);
                        Console.Write(" ");
                    }
                }
            }
            for (int i = 1; i <= wielkosc; i++)
            {
                if (i == 1)
                {
                    Console.SetCursorPosition(x + 1, y);
                    Console.Write(" ");
                }
                else
                {
                    for (int j = 1; j <= i * 2 - 1; j++)
                    {
                        Console.SetCursorPosition(x + i, y - i + j);
                        Console.Write(" ");
                    }
                }
            }
        }

        public static void czyszczenie_wskazania_zewn(int x, int y, int wielkosc)
        {
            for (int i = 0; i < wielkosc * 2 + 1; i++)
            {
                Console.SetCursorPosition(x - wielkosc + i, y - wielkosc - 1);
                Console.Write(" ");
            }
            for (int i = 0; i < wielkosc * 2 + 1; i++)
            {
                Console.SetCursorPosition(x - wielkosc + i, y + wielkosc + 1);
                Console.Write(" ");
            }
            for (int i = 0; i < wielkosc * 2 + 1; i++)
            {
                Console.SetCursorPosition(x - wielkosc - 1, y - wielkosc + i);
                Console.Write(" ");
            }
            for (int i = 0; i < wielkosc * 2 + 1; i++)
            {
                Console.SetCursorPosition(x + wielkosc + 1, y - wielkosc + i);
                Console.Write(" ");
            }
        }

    }
}
