using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Rysuj_logo
    {
        public Rysuj_logo(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Ramka.Rysuj_ramke(0, 0, 45, 177);

            Console.SetCursorPosition(x, y);
            Console.WriteLine("___________________________________________________________________");
            Console.SetCursorPosition(x, y+1);
            Console.WriteLine("\\  _____  _____  __  _____    ______  __  __  _____  _____  _____  \\    ____    ____    ____    ____");
            Console.SetCursorPosition(x, y+2);
            Console.WriteLine(" \\ \\  __\\ \\  _ \\ \\ \\ \\  __\\   \\  __ \\ \\ \\ \\ \\ \\  __\\ \\  __\\ \\_  _\\  \\   \\   \\   \\   \\   \\   \\   \\   \\");
            Console.SetCursorPosition(x, y+3);
            Console.WriteLine("  \\ \\  _\\_ \\  __\\ \\ \\ \\ \\__    \\ \\_\\ \\ \\ \\_\\ \\ \\  _\\_ \\__  \\  \\ \\    \\   \\___\\   \\___\\   \\___\\   \\___\\");
            Console.SetCursorPosition(x, y+4);
            Console.WriteLine("   \\ \\____\\ \\_\\    \\_\\ \\____\\   \\___\\ \\ \\_____\\ \\____\\ \\____\\  \\_\\    \\___________________________________");
            Console.SetCursorPosition(x, y+5);
            Console.WriteLine("    \\______________________________ \\__\\ _____  ______  _____    _____  _____  _____  _____  _____  _____ \\");
            Console.SetCursorPosition(x, y+6);
            Console.WriteLine("          ____   ____   ____       \\___  \\   _\\ \\  __ \\ \\  _ \\  \\  _  \\ \\  __\\ \\_  _\\ \\_  _\\ \\  __\\ \\  _ \\ \\");
            Console.SetCursorPosition(x, y+7);
            Console.WriteLine("          \\   \\  \\   \\  \\   \\          \\  \\  __\\ \\ \\_\\ \\ \\   _\\  \\  _  \\ \\  _\\_  \\ \\    \\ \\   \\  _\\_ \\   _\\ \\");
            Console.SetCursorPosition(x, y+8);
            Console.WriteLine("           \\___\\  \\___\\  \\___\\          \\  \\_\\    \\_____\\ \\_\\_\\   \\_____\\ \\____\\  \\_\\    \\_\\   \\____\\ \\_\\_\\  \\");
            Console.SetCursorPosition(x, y+9);
            Console.WriteLine("                                         \\_________________________  __     ______  ______  _____   __  ______\\");
            Console.SetCursorPosition(x, y+10);
            Console.WriteLine("                                                                   \\ \\ \\    \\  __ \\ \\  __ \\ \\_  _\\  \\ \\ \\");
            Console.SetCursorPosition(x, y+11);
            Console.WriteLine("                                                                    \\ \\ \\___ \\ \\_\\ \\ \\ \\_\\ \\  \\ \\    \\_\\ \\");
            Console.SetCursorPosition(x, y+12);
            Console.WriteLine("                                                                     \\ \\____\\ \\_____\\ \\_____\\  \\_\\    \\_\\ \\");
            Console.SetCursorPosition(x, y+13);
            Console.WriteLine("                                                                      \\____________________________________\\");
        }
    }
}
