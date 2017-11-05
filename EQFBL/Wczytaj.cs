using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EQFBL
{
    class Wczytaj
    {
        public static string wczytaj()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Ramka.Rysuj_ramke(60, 12, 15, 60);

            int j = 0;
            string do_wczytania ,tmp , bohater = String.Empty, plecak = String.Empty;
            

            Console.SetCursorPosition(73, 14);
            Console.Write("Znaleniono następujących bohaterów.");
            Console.SetCursorPosition(75, 15);
            Console.Write("Którego z nich chcesz wczytać?");
            Console.SetCursorPosition(70, 23);
            Console.Write("[                                         ]");
            
            


            using (StreamReader file = new StreamReader(@"Zapis/bohaterowie.txt"))
            {
                string[] wejscie = file.ReadLine().Split();
                string[] tab_nazw = new string[wejscie.Length / 2];


                for (int i = 0; i < tab_nazw.Length; i++)
                {
                    tab_nazw[i] = wejscie[j];
                    j += 2;
                }

                for (int i = 0; i < tab_nazw.Length; i++)
                {
                    Console.SetCursorPosition(70, 17+i);
                    Console.WriteLine(tab_nazw[i]);
                }
            }
            Console.SetCursorPosition(72, 23);
            do_wczytania = Console.ReadLine();

            tmp = "Zapis/" + do_wczytania + ".txt";
            if (File.Exists(@tmp))
            {
                using (StreamReader file = new StreamReader(@"Zapis/" + do_wczytania + ".txt"))
                {
                    bohater = file.ReadLine();
                } 
            }
            tmp = "Zapis/" + do_wczytania + "_Plecak.txt";
            if (File.Exists(@tmp))
            {
                using (StreamReader file = new StreamReader(@"Zapis/" + do_wczytania + "_Plecak.txt"))
                {
                    plecak = file.ReadLine();
                }
            }

            string wczytane = bohater + " " + plecak;

            Console.WriteLine(wczytane);
            return wczytane;
        }
    }
}
