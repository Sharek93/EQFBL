using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Kreator_Postaci
    {
        public static string kreator_postaci()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Wojownik woj = new Wojownik();
            woj.wojownik();
            Lotr lotr = new Lotr();
            lotr.lotr();
            Bron uzbrojenie = new Bron();
            Pancerz opancerzenie = new Pancerz();

            string[] ograniczenia = new string[10];            

            string klasa = "Wojownik", pancerz = "średni", bron = "miecz", nazwa;
            int indeks, zycie = 0, stamina = 0;

            Ramka.Rysuj_ramke(0, 0, 45, 177);
            Ramka.Rysuj_ramke(150, 0, 45, 27);

            //-------------------------------Klasa: Wojownik
        
            Ramka.Rysuj_ramke(0, 0, 11, 177);
            Ramka.Rysuj_ramke(150, 0, 11, 27);
            Ramka.Rysuj_ramke(75, 0, 11, 74);

            Console.SetCursorPosition(25, 3);
            Console.WriteLine("[ WOJOWNIK ]");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("Życie: {0}", woj.Zwroc_pocz_zycie);
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("Wytrzymałość: {0}", woj.Zwroc_pocz_stamine);
            Console.SetCursorPosition(20, 6);
            Console.Write("Dostępna Broń: ");
            woj.Zwroc_ograniczenia_broni.CopyTo(ograniczenia, 0);
            for (int i = 0; i < woj.Zwroc_ograniczenia_broni.Length; i++)
            {
                Console.Write("{0}, ",ograniczenia[i]);
            }
            Console.SetCursorPosition(20, 7);
            Console.Write("Dostępne pancerze: ");
            woj.Zwroc_ograniczenia_pancerzy.CopyTo(ograniczenia, 0);
            for (int i = 0; i < woj.Zwroc_ograniczenia_pancerzy.Length; i++)
            {
                Console.Write("{0}, ", ograniczenia[i]);
            }

            //-------------------------------Klasa: Łotr

            Console.SetCursorPosition(105, 3);
            Console.WriteLine("[ ŁOTR ]");
            Console.SetCursorPosition(100, 4);
            Console.WriteLine("Życie: {0}", lotr.Zwroc_pocz_zycie);
            Console.SetCursorPosition(100, 5);
            Console.WriteLine("Wytrzymałość: {0}", lotr.Zwroc_pocz_stamine);
            Console.SetCursorPosition(100, 6);
            Console.Write("Dostępna Broń: ");
            lotr.Zwroc_ograniczenia_broni.CopyTo(ograniczenia, 0);
            for (int i = 0; i < lotr.Zwroc_ograniczenia_broni.Length; i++)
            {
                Console.Write("{0}, ", ograniczenia[i]);
            }
            Console.SetCursorPosition(100, 7);
            Console.Write("Dostępne pancerze: ");
            lotr.Zwroc_ograniczenia_pancerzy.CopyTo(ograniczenia, 0);
            for (int i = 0; i < lotr.Zwroc_ograniczenia_pancerzy.Length; i++)
            {
                Console.Write("{0}, ", ograniczenia[i]);
            }

            Console.SetCursorPosition(158, 3);
            Console.WriteLine("Wybierz Klasę:");
            Menu menu1 = new Menu(2);
            menu1.UstawElement("      Wojownik      ", 0);
            menu1.UstawElement("      Łotr          ", 1);
            menu1.Dzialaj(155,5);
            indeks = menu1.Indeks_wybranego;

            switch (indeks)
            {
                case 0:
                    klasa = "Wojownik";
                    zycie = woj.Zwroc_pocz_zycie;
                    stamina = woj.Zwroc_pocz_stamine;
                    break;
                case 1:
                    klasa = "Łotr";
                    zycie = lotr.Zwroc_pocz_zycie;
                    stamina = lotr.Zwroc_pocz_stamine;
                    break;
            }

            //-------------------------------Wybór Broni

            switch (klasa)
            {
                case "Wojownik":
                    {
                        Ramka.Rysuj_ramke(0, 10, 11, 177);
                        Ramka.Rysuj_ramke(150, 10, 11, 27);
                        Ramka.Rysuj_ramke(0, 10, 11, 50);
                        Ramka.Rysuj_ramke(51, 10, 11, 50);
                        Console.SetCursorPosition(75, 10);
                        Console.WriteLine("#");

                        uzbrojenie.bron("miecz");
                        Console.SetCursorPosition(20, 13);
                        Console.WriteLine("[ MIECZ ]");
                        Console.SetCursorPosition(12, 14);
                        Console.WriteLine("Obrażenia bez osłony: {0}",uzbrojenie.Obrazenia_goly);
                        Console.SetCursorPosition(12, 15);
                        Console.WriteLine("Obrażenia za osłoną: {0}",uzbrojenie.Obrazenia_zasloniety);
                        Console.SetCursorPosition(12, 16);
                        Console.WriteLine("Koszt wytrzynałości: {0}",uzbrojenie.Zmeczenie);

                        uzbrojenie.bron("buława");
                        Console.SetCursorPosition(72, 13);
                        Console.WriteLine("[ BUŁAWA ]");
                        Console.SetCursorPosition(66, 14);
                        Console.WriteLine("Obrażenia bez osłony: {0}", uzbrojenie.Obrazenia_goly);
                        Console.SetCursorPosition(66, 15);
                        Console.WriteLine("Obrażenia za osłoną: {0}", uzbrojenie.Obrazenia_zasloniety);
                        Console.SetCursorPosition(66, 16);
                        Console.WriteLine("Koszt wytrzynałości: {0}", uzbrojenie.Zmeczenie);

                        uzbrojenie.bron("topór");
                        Console.SetCursorPosition(122, 13);
                        Console.WriteLine("[ TOPÓR ]");
                        Console.SetCursorPosition(116, 14);
                        Console.WriteLine("Obrażenia bez osłony: {0}", uzbrojenie.Obrazenia_goly);
                        Console.SetCursorPosition(116, 15);
                        Console.WriteLine("Obrażenia za osłoną: {0}", uzbrojenie.Obrazenia_zasloniety);
                        Console.SetCursorPosition(116, 16);
                        Console.WriteLine("Koszt wytrzynałości: {0}", uzbrojenie.Zmeczenie);

                        Console.SetCursorPosition(158, 12);
                        Console.WriteLine("Wybierz Broń:");
                        Console.SetCursorPosition(151, 18);
                        Console.WriteLine("Obrażenia zwiakszają się ze");
                        Console.SetCursorPosition(153, 19);
                        Console.WriteLine("wzrostem poziomu broni");
                        Menu menu2 = new Menu(3);
                        menu2.UstawElement("      Miecz         ", 0);
                        menu2.UstawElement("      Buława        ", 1);
                        menu2.UstawElement("      Topór         ", 2);
                        menu2.Dzialaj(155, 14);
                        indeks = menu2.Indeks_wybranego;

                        switch (indeks)
                        {
                            case 0:
                                bron = "miecz";
                                break;
                            case 1:
                                bron = "buława";
                                break;
                            case 2:
                                bron = "topór";
                                break;
                        }
                        break;                       
                    }
                case "Łotr":
                    {
                        Ramka.Rysuj_ramke(0, 10, 11, 177);
                        Ramka.Rysuj_ramke(150, 10, 11, 27);
                        Ramka.Rysuj_ramke(75, 10, 11, 74);

                        uzbrojenie.bron("sztylet");
                        Console.SetCursorPosition(25, 13);
                        Console.WriteLine("[ SZTYLET ]");
                        Console.SetCursorPosition(20, 14);
                        Console.WriteLine("Obrażenia bez osłony: {0}", uzbrojenie.Obrazenia_goly);
                        Console.SetCursorPosition(20, 15);
                        Console.WriteLine("Obrażenia za osłoną: {0}", uzbrojenie.Obrazenia_zasloniety);
                        Console.SetCursorPosition(20, 16);
                        Console.WriteLine("Koszt wytrzynałości: {0}", uzbrojenie.Zmeczenie);

                        uzbrojenie.bron("miecz");
                        Console.SetCursorPosition(105, 13);
                        Console.WriteLine("[ MIECZ ]");
                        Console.SetCursorPosition(100, 14);
                        Console.WriteLine("Obrażenia bez osłony: {0}", uzbrojenie.Obrazenia_goly);
                        Console.SetCursorPosition(100, 15);
                        Console.WriteLine("Obrażenia za osłoną: {0}", uzbrojenie.Obrazenia_zasloniety);
                        Console.SetCursorPosition(100, 16);
                        Console.WriteLine("Koszt wytrzynałości: {0}", uzbrojenie.Zmeczenie);

                        Console.SetCursorPosition(158, 13);
                        Console.WriteLine("Wybierz Broń:");
                        Console.SetCursorPosition(151, 18);
                        Console.WriteLine("Obrażenia zwiakszają się ze");
                        Console.SetCursorPosition(153, 19);
                        Console.WriteLine("wzrostem poziomu broni");
                        Menu menu2 = new Menu(2);
                        menu2.UstawElement("      Sztylet       ", 0);
                        menu2.UstawElement("      Miecz         ", 1);
                        menu2.Dzialaj(155, 15);
                        indeks = menu2.Indeks_wybranego;

                        switch (indeks)
                        {
                            case 0:
                                bron = "sztylet";
                                break;
                            case 1:
                                bron = "miecz";
                                break;
                        }
                        break;
                    }
            }

            //-------------------------------Wybór Pancerza

            switch (klasa)
            {
                case "Wojownik":
                    {
                        Ramka.Rysuj_ramke(0, 20, 11, 177);
                        Ramka.Rysuj_ramke(150, 20, 11, 27);
                        Ramka.Rysuj_ramke(75, 20, 11, 74);

                        opancerzenie.pancerz("średni");
                        Console.SetCursorPosition(25, 23);
                        Console.WriteLine("[ ŚREDNI ]");
                        Console.SetCursorPosition(20, 24);
                        Console.WriteLine("Bonus do życia: {0}", opancerzenie.Bonus_zycia);
                        Console.SetCursorPosition(20, 25);
                        Console.WriteLine("Bounus do zużycia Wytrzymałości: {0}", opancerzenie.Bonus_staminy);
                        Console.SetCursorPosition(7, 27);
                        Console.WriteLine("Bounus do zużycia Wytrzymałości zmniejsza zmęczenie wywołane ");
                        Console.SetCursorPosition(11, 28);
                        Console.WriteLine("korzystaniem z broni. Pozwala to zadać więcej ciosów");
                        Console.SetCursorPosition(12, 29);
                        Console.WriteLine("korzystając z tej samej puli punktów wytrzymałości");

                        opancerzenie.pancerz("ciężki");
                        Console.SetCursorPosition(105, 23);
                        Console.WriteLine("[ CIĘŻKI ]");
                        Console.SetCursorPosition(100, 24);
                        Console.WriteLine("Bonus do życia: {0}", opancerzenie.Bonus_zycia);
                        Console.SetCursorPosition(100, 25);
                        Console.WriteLine("Bounus do zużycia Wytrzymałości: {0}", opancerzenie.Bonus_staminy);
                        Console.SetCursorPosition(87, 27);
                        Console.WriteLine("Bounus do zużycia Wytrzymałości zmniejsza zmęczenie wywołane ");
                        Console.SetCursorPosition(91, 28);
                        Console.WriteLine("korzystaniem z broni. Pozwala to zadać więcej ciosów");
                        Console.SetCursorPosition(92, 29);
                        Console.WriteLine("korzystając z tej samej puli punktów wytrzymałości");


                        Console.SetCursorPosition(157, 22);
                        Console.WriteLine("Wybierz Pancerz:");
                        Console.SetCursorPosition(157, 27);
                        Console.WriteLine("Bonus do życia");
                        Console.SetCursorPosition(156, 28);
                        Console.WriteLine("zwiakszają się ze");
                        Console.SetCursorPosition(152, 29);
                        Console.WriteLine("wzrostem poziomu pancerza");
                        Menu menu3 = new Menu(2);
                        menu3.UstawElement("      Średni        ", 0);
                        menu3.UstawElement("      Ciężki        ", 1);
                        menu3.Dzialaj(155, 24);
                        indeks = menu3.Indeks_wybranego;

                        switch (indeks)
                        {
                            case 0:
                                pancerz = "średni";
                                break;
                            case 1:
                                pancerz = "ciężki";
                                break;
                        }
                        break;
                    }
                case "Łotr":
                    {
                        Ramka.Rysuj_ramke(0, 20, 11, 177);
                        Ramka.Rysuj_ramke(150, 20, 11, 27);
                        Ramka.Rysuj_ramke(75, 20, 11, 74);

                        opancerzenie.pancerz("lekki");
                        Console.SetCursorPosition(25, 23);
                        Console.WriteLine("[ LEKKI ]");
                        Console.SetCursorPosition(20, 24);
                        Console.WriteLine("Bonus do życia: {0}", opancerzenie.Bonus_zycia);
                        Console.SetCursorPosition(20, 25);
                        Console.WriteLine("Bounus do zużycia Wytrzymałości: {0}", opancerzenie.Bonus_staminy);
                        Console.SetCursorPosition(7, 27);
                        Console.WriteLine("Bounus do zużycia Wytrzymałości zmniejsza zmęczenie wywołane ");
                        Console.SetCursorPosition(11, 28);
                        Console.WriteLine("korzystaniem z broni. Pozwala to zadać więcej ciosów");
                        Console.SetCursorPosition(12, 29);
                        Console.WriteLine("korzystając z tej samej puli punktów wytrzymałości");

                        opancerzenie.pancerz("średni");
                        Console.SetCursorPosition(105, 23);
                        Console.WriteLine("[ ŚREDNI ]");
                        Console.SetCursorPosition(100, 24);
                        Console.WriteLine("Bonus do życia: {0}", opancerzenie.Bonus_zycia);
                        Console.SetCursorPosition(100, 25);
                        Console.WriteLine("Bounus do zużycia Wytrzymałości: {0}", opancerzenie.Bonus_staminy);
                        Console.SetCursorPosition(87, 27);
                        Console.WriteLine("Bounus do zużycia Wytrzymałości zmniejsza zmęczenie wywołane ");
                        Console.SetCursorPosition(91, 28);
                        Console.WriteLine("korzystaniem z broni. Pozwala to zadać więcej ciosów");
                        Console.SetCursorPosition(92, 29);
                        Console.WriteLine("korzystając z tej samej puli punktów wytrzymałości");

                        Console.SetCursorPosition(157, 22);
                        Console.WriteLine("Wybierz Pancerz:");
                        Console.SetCursorPosition(157, 27);
                        Console.WriteLine("Bonus do życia");
                        Console.SetCursorPosition(156, 28);
                        Console.WriteLine("zwiakszają się ze");
                        Console.SetCursorPosition(152, 29);
                        Console.WriteLine("wzrostem poziomu pancerza");
                        Menu menu3 = new Menu(2);
                        menu3.UstawElement("      Lekki        ", 0);
                        menu3.UstawElement("      Średni        ", 1);
                        menu3.Dzialaj(155, 24);
                        indeks = menu3.Indeks_wybranego;

                        switch (indeks)
                        {
                            case 0:
                                pancerz = "lekki";
                                break;
                            case 1:
                                pancerz = "średni";
                                break;
                        }
                        break;
                    }
            }
            Console.SetCursorPosition(42, 40);
            Console.WriteLine("Broń i Pancerz można potem zmienić korzystając z usług Kowala w mieście");

            Console.SetCursorPosition(157, 35);
            Console.WriteLine("Wybierz nazwę:");

            Console.SetCursorPosition(54, 35);
            Console.WriteLine("Wymyśl jakąś krzepką ksywę dla swojego wojaka");
            Console.SetCursorPosition(54, 37);
            Console.WriteLine("[                                            ]");
            Console.SetCursorPosition(55, 37);
            nazwa = Console.ReadLine();
            Console.SetCursorPosition(50, 41);
            Console.WriteLine("Naciśnij dowolny klawisz aby przejść do podumowania");


            Console.ReadKey();
            Console.Clear();
            Ramka.Rysuj_ramke(60, 12, 15, 60);
            Console.SetCursorPosition(80, 14);
            Console.WriteLine("Podsumowanie Kreatora:");
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("Wybrana Klasa:");
            Console.SetCursorPosition(65, 17);
            Console.WriteLine(klasa);
            Console.SetCursorPosition(85, 16);
            Console.WriteLine("Wybrany pancerz:");
            Console.SetCursorPosition(85, 17);
            Console.WriteLine(pancerz);
            Console.SetCursorPosition(105, 16);
            Console.WriteLine("Wybrana broń:");
            Console.SetCursorPosition(105, 17);
            Console.WriteLine(bron);
            Console.SetCursorPosition(85, 19);
            Console.WriteLine("Nazwa Wojaka:");
            Console.SetCursorPosition(90 - nazwa.Length/2, 21);
            Console.WriteLine(nazwa);

            Console.SetCursorPosition(82, 23);
            Console.WriteLine("Lecimy z tym koksem !");
            Console.SetCursorPosition(70, 24);
            Console.WriteLine("Naciśnij dowolny klawisz aby wejsc do miasta");
            Console.SetCursorPosition(90, 25);



            string wynik = nazwa+" "+klasa+" "+Convert.ToString(zycie)+" "+Convert.ToString(stamina) + " "+bron+" "+pancerz;

            Console.ReadKey();

            return wynik;
        }
    }
}
