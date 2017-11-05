using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Walka
    {
        int lup;

        private Potwor generuj_potwora(int poziom)
        {
            Random rand = new Random();
            int jaki_potwor;

            Potwor szczur = new Szczur();
            Potwor zombie = new Zombie();
            Potwor szkieletor = new Szkieletor();
            Potwor smocze = new Smocze_dziecie();

            if (poziom == 1)
            {
                
                szczur.potwor(poziom);
                return szczur;

            }
            else if (poziom > 1 && poziom <= 3)
            {
                jaki_potwor = rand.Next(0, 2);

                switch (jaki_potwor)
                {
                    case 0:
                        {                           
                            szczur.potwor(poziom);
                            return szczur;
                        }
                    case 1:
                        {                            
                            zombie.potwor(poziom);
                            return zombie;
                        }
                    default:
                        {                            
                            szczur.potwor(poziom);
                            return szczur;
                        }
                }
            }
            else if (poziom > 3 && poziom <=5)
            {
                jaki_potwor = rand.Next(0, 3);

                switch (jaki_potwor)
                {
                    case 0:
                        {                            
                            szczur.potwor(poziom);
                            return szczur;
                        }
                    case 1:
                        {                            
                            zombie.potwor(poziom);
                            return zombie;
                        }
                    case 2:
                        {                            
                            szkieletor.potwor(poziom);
                            return szkieletor;
                        }
                    default:
                        {                            
                            szczur.potwor(poziom);
                            return szczur;
                        }
                }

            }
            else if (poziom > 5)
            {
                jaki_potwor = rand.Next(0, 10);

                if (jaki_potwor >= 0 && jaki_potwor <=2)
                {                    
                    szczur.potwor(poziom);
                    return szczur;
                }
                if (jaki_potwor >= 3 && jaki_potwor <= 5)
                {                    
                    zombie.potwor(poziom);
                    return zombie;
                }
                if (jaki_potwor >= 6 && jaki_potwor <= 8)
                {                    
                    szkieletor.potwor(poziom);
                    return szkieletor;
                }
                if (jaki_potwor == 9)
                {                    
                    smocze.potwor(poziom);
                    return smocze;
                }
            }  
            else
            {                
                szczur.potwor(poziom);
                return szczur;
            }

            return smocze;

        }

        private void Rysuj_interface(Bohater bohater, Potwor potwor, Bron bron, Pancerz pancerz, Ekwipunek plecak)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Ramka.Rysuj_ramke(0, 0, 45, 177);

            Ramka.Rysuj_ramke(140, 0, 45, 37);
            Ramka.Rysuj_ramke(0, 0, 9, 139);
            Ramka.Rysuj_ramke(140, 0, 5, 37);
            Ramka.Rysuj_ramke(0, 0, 9, 70);

            Ramka.Rysuj_ramke(0, 8, 28, 139);
            Ramka.Rysuj_ramke(0, 8, 28, 70);

            Ramka.Rysuj_ramke(0, 35, 10, 70);
            Ramka.Rysuj_ramke(140, 37, 8, 37);

            //Nazwy górnych Paneli

            Console.SetCursorPosition(35 - (bohater.Nazwa.Length + bohater.Klasa.Length +21)/2, 0);
            Console.Write("[ Bohater: {0} ({1})]", bohater.Nazwa, bohater.Klasa);

            Console.SetCursorPosition(105 - (potwor.Nazwa.Length + potwor.Typ.Length + 21) / 2, 0);
            Console.Write("[ Potwor: {0} {1} (LVL:{2})]", potwor.Typ, potwor.Nazwa, potwor.Poziom);

            Console.SetCursorPosition(152,2);
            Console.Write("Dziennik Walki: ");

            //Dynamiczne statystyki bohatera

            Console.SetCursorPosition(22, 2);
            Console.Write("Życie");
            Console.SetCursorPosition(55, 2);
            Console.Write("Pancerz");

            Console.SetCursorPosition(2, 3);
            Console.Write("0");
            Console.SetCursorPosition(45, 3);
            Console.Write("{0} | 0", bohater.Max_zycie);
            Console.SetCursorPosition(67, 3);
            Console.Write("{0}", pancerz.Bonus_zycia);

            Console.SetCursorPosition(30, 5);
            Console.Write("Wytrzymałość");

            Console.SetCursorPosition(2, 6);
            Console.Write("0");
            Console.SetCursorPosition(67, 6);
            Console.WriteLine("{0}", bohater. Max_stamina);

            //Dynamiczne statystyki potwora

            Console.SetCursorPosition(73, 3);
            Console.Write("0");
            Console.SetCursorPosition(136, 3);
            Console.Write("{0}", potwor.Max_zycie);

            //Statyczne statystyki bohatara

            Console.SetCursorPosition(28, 35);
            Console.Write("[ Statystyki: ]");
            Console.SetCursorPosition(98, 35);
            Console.Write("[ Statystyki: ]");

            Console.SetCursorPosition(10, 37);
            Console.Write("Broń: {0} (Poziom: {1}) | Obrażenia: {2}/{3}", plecak.Bron, plecak.Poziom_broni, bron.Obrazenia_goly, bron.Obrazenia_zasloniety);
            Console.SetCursorPosition(10, 38);
            Console.Write("Pancerz: {0} (Poziom: {1}) | Bonus (życie/wytrz): {2}/{3}", plecak.Pancerz, plecak.Poziom_Pancerza, pancerz.Bonus_zycia, pancerz.Bonus_staminy);

            //Statyczne statystyki potwora

            Console.SetCursorPosition(95, 37);
            Console.Write("Obrażenia: {0}", potwor.Obrazenia);
            Console.SetCursorPosition(95, 38);
            Console.Write("Łup z potwora: {0}", potwor.Kasa);

            //Statystyki prawego-dolnego rogu

            Console.SetCursorPosition(145, 39);
            Console.Write("Łączny Łup: [ {0} ]", lup);
            Console.SetCursorPosition(145, 41);
            Console.Write("Liczba potionów: {0}/{1}", plecak.Ile_potionow, plecak.Ile_max_potionow);

        }

        public Walka(Bohater bohater, Ekwipunek plecak, Bron bron, Pancerz pancerz)
        {
            Random rand = new Random();
            ConsoleKeyInfo k = new ConsoleKeyInfo();

            int pozycja_kursora_Logu = 6;

            int odliczanie_do_ataku = 0;
            int czyszczenie_informacji = 0;
            bool czy_czyslcimy = false;
            bool czy_atak_gracza = false;
            bool czy_atak = false;
            bool czy_konczymy = false;
            int Szansa_na_atak = 0;
            int Szansa_na_zmiane_obrony = 0;
            string[] kierunek = { "góra", "dół", "lewo", "prawo" };


            bool czy_lecimy_dalej = false;
            int poziom = 1;
            string kierunek_ataku_potwora = "góra", kierunek_bez_obrony_potwora = "góra";
            string kierunek_obrony_gracza = "góra", kierunek_ataku_gracza = "góra";

            do
            {
                Console.Clear();
                Potwor potwor = generuj_potwora(poziom);
                Rysuj_interface(bohater, potwor, bron, pancerz, plecak);



                while ((bohater.Czy_Zyje == true && potwor.Czy_zyje == true) && czy_konczymy == false)
                {
                    if (Console.KeyAvailable)
                    {
                        k = Console.ReadKey();
                        if (k.Key == ConsoleKey.Escape)
                        {
                            czy_konczymy = true;
                        }
                        else if (k.Key == ConsoleKey.W || k.Key == ConsoleKey.S || k.Key == ConsoleKey.A || k.Key == ConsoleKey.D)
                        {
                            switch (k.Key)
                            {
                                case ConsoleKey.W:
                                    Wskaznik_ataku.czyszczenie_wskazania_wewn_gracza(35, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("", "góra", 35, 20, 7);
                                    kierunek_obrony_gracza = "góra";
                                    break;
                                case ConsoleKey.S:
                                    Wskaznik_ataku.czyszczenie_wskazania_wewn_gracza(35, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("", "dół", 35, 20, 7);
                                    kierunek_obrony_gracza = "dół";
                                    break;
                                case ConsoleKey.A:
                                    Wskaznik_ataku.czyszczenie_wskazania_wewn_gracza(35, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("", "lewo", 35, 20, 7);
                                    kierunek_obrony_gracza = "lewo";
                                    break;
                                case ConsoleKey.D:
                                    Wskaznik_ataku.czyszczenie_wskazania_wewn_gracza(35, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("", "prawo", 35, 20, 7);
                                    kierunek_obrony_gracza = "prawo";
                                    break;

                            }
                        }
                        else if (k.Key == ConsoleKey.UpArrow || k.Key == ConsoleKey.DownArrow || k.Key == ConsoleKey.LeftArrow || k.Key == ConsoleKey.RightArrow)
                        {
                            switch (k.Key)
                            {
                                case ConsoleKey.UpArrow:
                                    Wskaznik_ataku.czyszczenie_wskazania_zewn(105, 20, 7);
                                    Wskaznik_ataku.Wskazanie_potwora("góra", "", 105, 20, 7);
                                    if (bohater.Stamina >= bron.Zmeczenie - pancerz.Bonus_staminy)
                                    {
                                        kierunek_ataku_gracza = "góra";
                                        bohater.Zmecznie(bron.Zmeczenie - pancerz.Bonus_staminy);
                                        czy_atak_gracza = true;
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(95, 29);
                                        Console.Write("Jesteś zbyt wyczerpany!");
                                        czy_czyslcimy = true;
                                    }
                                    break;
                                case ConsoleKey.DownArrow:
                                    Wskaznik_ataku.czyszczenie_wskazania_zewn(105, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("dół", "", 105, 20, 7);
                                    if (bohater.Stamina >= bron.Zmeczenie - pancerz.Bonus_staminy)
                                    {
                                        kierunek_ataku_gracza = "dół";
                                        bohater.Zmecznie(bron.Zmeczenie - pancerz.Bonus_staminy);
                                        czy_atak_gracza = true;
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(95, 29);
                                        Console.Write("Jesteś zbyt wyczerpany!");
                                        czy_czyslcimy = true;
                                    }
                                    break;
                                case ConsoleKey.LeftArrow:
                                    Wskaznik_ataku.czyszczenie_wskazania_zewn(105, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("lewo", "", 105, 20, 7);
                                    if (bohater.Stamina >= bron.Zmeczenie - pancerz.Bonus_staminy)
                                    {
                                        kierunek_ataku_gracza = "lewo";
                                        bohater.Zmecznie(bron.Zmeczenie - pancerz.Bonus_staminy);
                                        czy_atak_gracza = true;
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(95, 29);
                                        Console.Write("Jesteś zbyt wyczerpany!");
                                        czy_czyslcimy = true;
                                    }
                                    break;
                                case ConsoleKey.RightArrow:
                                    Wskaznik_ataku.czyszczenie_wskazania_zewn(105, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("prawo", "", 105, 20, 7);
                                    if (bohater.Stamina >= bron.Zmeczenie - pancerz.Bonus_staminy)
                                    {
                                        kierunek_ataku_gracza = "prawo";
                                        bohater.Zmecznie(bron.Zmeczenie - pancerz.Bonus_staminy);
                                        czy_atak_gracza = true;
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(95, 29);
                                        Console.Write("Jesteś zbyt wyczerpany!");
                                        czy_czyslcimy = true;
                                    }
                                    break;
                            }

                        }
                        else if(k.Key == ConsoleKey.Spacebar)
                        {
                            if (plecak.Ile_potionow > 0)
                            {
                                Console.SetCursorPosition(20, 29);
                                Console.Write("                               ");
                                Console.SetCursorPosition(28, 29);
                                Console.Write("Używasz Potiona");
                                czy_czyslcimy = true;
                                bohater.Regeneracja_zycia(40);
                                plecak.minus_potion();
                            }
                            else
                            {
                                Console.SetCursorPosition(20, 29);
                                Console.Write("                               ");
                                Console.SetCursorPosition(28, 29);
                                Console.Write("Nie masz Potionów");
                                czy_czyslcimy = true;
                            }
                        }
                        else
                        {
                        }
                    }

                    if (Szansa_na_zmiane_obrony > rand.Next(5, 95))
                    {
                        kierunek_bez_obrony_potwora = kierunek[rand.Next(0, 4)];

                        switch (kierunek_bez_obrony_potwora)
                        {
                            case "góra":
                                {
                                    Wskaznik_ataku.Wskazanie_potwora("", "góra", 105, 20, 7);
                                    Szansa_na_zmiane_obrony = 0;
                                    break;
                                }
                            case "dół":
                                {
                                    Wskaznik_ataku.Wskazanie_potwora("", "dół", 105, 20, 7);
                                    Szansa_na_zmiane_obrony = 0;
                                    break;
                                }
                            case "lewo":
                                {
                                    Wskaznik_ataku.Wskazanie_potwora("", "lewo", 105, 20, 7);
                                    Szansa_na_zmiane_obrony = 0;
                                    break;
                                }
                            case "prawo":
                                {
                                    Wskaznik_ataku.Wskazanie_potwora("", "prawo", 105, 20, 7);
                                    Szansa_na_zmiane_obrony = 0;
                                    break;
                                }
                            default:
                                break;
                        }
                    }

                    if (Szansa_na_atak > rand.Next(1, 100))
                    {
                        kierunek_ataku_potwora = kierunek[rand.Next(0, 4)];

                        switch (kierunek_ataku_potwora)
                        {
                            case "góra":
                                {
                                    Wskaznik_ataku.czyszczenie_wskazania_zewn(35, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("góra", "", 35, 20, 7);
                                    Szansa_na_atak = 0;
                                    czy_atak = true;
                                    break;
                                }
                            case "dół":
                                {
                                    Wskaznik_ataku.czyszczenie_wskazania_zewn(35, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("dół", "", 35, 20, 7);
                                    Szansa_na_atak = 0;
                                    czy_atak = true;
                                    break;
                                }
                            case "lewo":
                                {
                                    Wskaznik_ataku.czyszczenie_wskazania_zewn(35, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("lewo", "", 35, 20, 7);
                                    Szansa_na_atak = 0;
                                    czy_atak = true;
                                    break;
                                }
                            case "prawo":
                                {
                                    Wskaznik_ataku.czyszczenie_wskazania_zewn(35, 20, 7);
                                    Wskaznik_ataku.Wskazanie_Gracza("prawo", "", 35, 20, 7);
                                    Szansa_na_atak = 0;
                                    czy_atak = true;
                                    break;
                                }
                            default:
                                break;
                        }
                    }

                    if (Szansa_na_atak < 100)
                    {
                        Szansa_na_atak += 1;
                    }
                    else
                    {
                        Szansa_na_atak = 100;
                    }
                                        
                    if (Szansa_na_zmiane_obrony < 100)
                    {
                        Szansa_na_zmiane_obrony += 10;
                    }
                    else
                    {
                        Szansa_na_zmiane_obrony = 100;
                    }

                    if (czy_atak == true)
                    {
                        Szansa_na_atak = 0;
                        if (kierunek_ataku_potwora != kierunek_obrony_gracza)
                        {
                            odliczanie_do_ataku++;
                            if (odliczanie_do_ataku >= 16)
                            {
                                if (pancerz.Zycie_pancerza > 0)
                                {
                                    pancerz.Obrażenia_pancerza(potwor.Obrazenia);
                                }
                                else
                                {
                                    bohater.Zadane_obrazenia(potwor.Obrazenia);
                                }                                
                                odliczanie_do_ataku = 0;
                                czy_atak = false;
                                Console.SetCursorPosition(20, 29);
                                Console.Write("                               ");
                                Console.SetCursorPosition(28, 29);
                                Console.Write("Obrona Nieudana!");
                                czy_czyslcimy = true;

                                Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                                Console.Write("{0} {1} atakuje",potwor.Typ,potwor.Nazwa);
                                Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                                Console.Write("Obrywasz za {0}!", potwor.Obrazenia);
                                Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                            }
                        }
                        else
                        {
                            odliczanie_do_ataku = 0;
                            czy_atak = false;
                            Console.SetCursorPosition(20, 29);
                            Console.Write("                               ");
                            Console.SetCursorPosition(28, 29);
                            Console.Write("Obrona Udana!");
                            czy_czyslcimy = true;

                            Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                            Console.Write("{0} {1} atakuje", potwor.Typ, potwor.Nazwa);
                            Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                            Console.Write("Bronisz się!");
                            Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                        }

                    }

                    if (czy_atak_gracza == true)
                    {
                        if (kierunek_ataku_gracza == kierunek_bez_obrony_potwora)
                        {
                            Console.SetCursorPosition(90, 29);
                            Console.Write("                               ");
                            Console.SetCursorPosition(98, 29);
                            Console.Write("Atak Udany!");
                            czy_czyslcimy = true;
                            potwor.Zadane_obrazenia(bron.Obrazenia_goly);

                            Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                            Console.Write("Twój atak ominął gardę");
                            Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                            Console.Write("Zadajesz {0} obrażeń", bron.Obrazenia_goly);
                            Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                        } 
                        else
                        {
                            if (bron.Obrazenia_zasloniety > 0)
                            {
                                Console.SetCursorPosition(90, 29);
                                Console.Write("                               ");
                                Console.SetCursorPosition(94, 29);
                                Console.Write("Atak w gardę Udany!");
                                czy_czyslcimy = true;
                                potwor.Zadane_obrazenia(bron.Obrazenia_zasloniety);

                                Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                                Console.Write("Twój atak rozbił gardę");
                                Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                                Console.Write("Zadajesz {0} obrażeń", bron.Obrazenia_zasloniety);
                                Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                            }
                            else
                            {
                                Console.SetCursorPosition(90, 29);
                                Console.Write("                               ");
                                Console.SetCursorPosition(96, 29);
                                Console.Write("Atak Sparowany!");
                                czy_czyslcimy = true;

                                Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                                Console.Write("Twój atak nie przeszedł gardy");
                                Console.SetCursorPosition(144, pozycja_kursora_Logu++);
                            }
                        }
                    }

                    if (czy_czyslcimy == true)
                    {
                        if (czyszczenie_informacji >= 8)
                        {
                            Console.SetCursorPosition(20, 29);
                            Console.Write("                               ");
                            Console.SetCursorPosition(90, 29);
                            Console.Write("                               ");
                            czyszczenie_informacji = 0;
                            czy_czyslcimy = false;
                        }
                        else
                        {
                            czyszczenie_informacji++;
                        } 
                    }

                    if (pozycja_kursora_Logu >=35)
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Console.SetCursorPosition(141, 6+i);
                            Console.WriteLine("                                     ");
                            pozycja_kursora_Logu = 6;
                        }
                    }

                    Pasek_postepu.pasek(4, 6, 1, 60, 0, Convert.ToDouble(bohater.Max_stamina), Convert.ToDouble(bohater.Stamina), 1);
                    Pasek_postepu.pasek(4, 3, 1, 38, 0, Convert.ToDouble(bohater.Max_zycie), Convert.ToDouble(bohater.Zycie), 1);
                    Pasek_postepu.pasek(54, 3, 1, 10, 0, Convert.ToDouble(pancerz.Bonus_zycia), Convert.ToDouble(pancerz.Zycie_pancerza), 1);
                    Pasek_postepu.pasek(75, 3, 2, 58, 0, Convert.ToDouble(potwor.Max_zycie), Convert.ToDouble(potwor.Zycie), 2);
                    bohater.Regeneracja_staminy(0.25);
                    czy_atak_gracza = false;
                    System.Threading.Thread.Sleep(125);
                }

                if (potwor.Czy_zyje == false)
                {
                    pozycja_kursora_Logu = 6;
                    lup = lup + potwor.Kasa;
                    poziom++;

                    Console.Clear();
                    Ramka.Rysuj_ramke(60, 12, 15, 60);
                    Console.SetCursorPosition(75, 20);
                    Console.Write("Gotory na następnego potwora?");
                    Console.SetCursorPosition(75, 22);
                    Console.Write("TAK [ENTER]   DO MIASTA [ESC]");
                    k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Enter)
                    {
                        czy_lecimy_dalej = true;
                    }
                    if (k.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Ramka.Rysuj_ramke(60, 12, 15, 60);
                        Console.SetCursorPosition(82, 16);
                        Console.Write("Wracasz do miasta");
                        Console.SetCursorPosition(85, 18);
                        Console.Write("ZEBRANY ŁUP");
                        Console.SetCursorPosition(90 - (Convert.ToString(lup).Length / 2), 20);
                        Console.Write(lup);
                        plecak.Zysk(lup);
                        czy_lecimy_dalej = false;
                    }
                }
                if (bohater.Czy_Zyje == false)
                {
                    Console.Clear();
                    Ramka.Rysuj_ramke(60, 12, 15, 60);
                    Console.SetCursorPosition(85, 16);
                    Console.Write("!!NIE ŻYJESZ!!");
                    Console.SetCursorPosition(70, 18);
                    Console.Write("ZOSTAJEZ ZABRANY DO MIASTA I WSKRZESZONY");
                    Console.SetCursorPosition(78, 20);
                    Console.Write("TRACISZ CAŁY ZEBRANY ŁUP");
                    Console.SetCursorPosition(90 - (Convert.ToString(lup).Length/2), 22);
                    Console.Write(lup);
                    Console.ReadKey();
                    czy_lecimy_dalej = false;
                }
                if (czy_konczymy == true)
                {
                    Console.Clear();
                    Ramka.Rysuj_ramke(60, 12, 15, 60);
                    Console.SetCursorPosition(82, 16);
                    Console.Write("Wracasz do miasta");
                    Console.SetCursorPosition(85, 18);
                    Console.Write("ZEBRANY ŁUP");
                    Console.SetCursorPosition(90 - (Convert.ToString(lup).Length / 2), 20);
                    Console.Write(lup);
                    plecak.Zysk(lup);
                    czy_lecimy_dalej = false;
                }
               
            }while (czy_lecimy_dalej == true);

            Console.ReadKey();
        }
    }
}
