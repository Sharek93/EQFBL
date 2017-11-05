using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Ekran_Startowy
    {
        public static int ekran_startowy()
        {
            int indeks;

            Rysuj_logo rysuj = new Rysuj_logo(27, 10);

            Console.SetCursorPosition(62, 30);
            Console.WriteLine("Naciśnij dowonly klawisz aby kontynuować.");
            Console.SetCursorPosition(103, 30);
            Console.ReadKey();
            Console.SetCursorPosition(62, 30);
            Console.WriteLine("                                         ");
            Console.SetCursorPosition(75, 30);

            Ramka.Rysuj_ramke(65, 30, 7, 30);

            Console.SetCursorPosition(75, 30);
            Console.WriteLine("Menu Główne:");


            Menu menuGlowne = new Menu(3);
            menuGlowne.UstawElement("      Nowa gra        ", 0);
            menuGlowne.UstawElement("      Wczytaj grę     ", 1);
            menuGlowne.UstawElement("      Wyjdz           ", 2);
            menuGlowne.Dzialaj(70, 32);

            indeks = menuGlowne.Indeks_wybranego;



            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            return indeks;
        }      
    }
}
