using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Program
    {
        //Nazwa robocza:
        //Epic quest for better loot (EQFBL)
        static void Main(string[] args)
        {
            Console.SetWindowSize(180,45);

            int indeks;
            bool wyjdz = false;
            string postac;

            Bohater wojak = new Wojownik();
            Bohater lotr = new Lotr();
            Ekwipunek plecak = new Ekwipunek();
            Pancerz pancerz = new Pancerz();
            Bron bron = new Bron();



            do
            {
                indeks = Ekran_Startowy.ekran_startowy();

                switch (indeks)
                {
                    case 0:
                        {
                            postac = Kreator_Postaci.kreator_postaci();
                            string[] temp = postac.Split(' ');
                            switch (temp[1])
                            {
                                case "Wojownik":
                                    {
                                        wojak.bohater(temp[0], Convert.ToInt32(temp[2]), Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]), Convert.ToInt32(temp[3]));
                                        plecak.ekwipunek(1, 50, 0, 1, 1, temp[4], temp[5]);
                                        pancerz.pancerz(plecak.Pancerz, plecak.Poziom_Pancerza);
                                        bron.bron(plecak.Bron, plecak.Poziom_broni);
                                        Miasto miasto = new Miasto(wojak, plecak, bron, pancerz);
                                        break;
                                    }
                                case "Łotr":
                                    {
                                        lotr.bohater(temp[0], Convert.ToInt32(temp[2]), Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]), Convert.ToInt32(temp[3]));
                                        plecak.ekwipunek(1, 50, 0, 1, 1, temp[4], temp[5]);
                                        pancerz.pancerz(plecak.Pancerz, plecak.Poziom_Pancerza);
                                        bron.bron(plecak.Bron, plecak.Poziom_broni);
                                        Miasto miasto = new Miasto(lotr, plecak, bron, pancerz);
                                        break;
                                    }
                                default:
                                    lotr.bohater("Kowalski Łotr Jeden :)", 100, 100, 100, 100);
                                    wojak.bohater("Kowalski Wojownik", 200, 200, 50, 50);
                                    break;
                            }
                            break;
                        }
                    case 1:
                        {
                            postac = Wczytaj.wczytaj();
                            string[] temp = postac.Split(' ');
                            //Kowalski_Wojownik Wojownik 200 200 50 1 100 1 1 1 sztylet lekki
                            switch (temp[1])
                            {
                                case "Wojownik":
                                    {
                                        wojak.bohater(temp[0], Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]), Convert.ToInt32(temp[4]), Convert.ToInt32(temp[4]));
                                        plecak.ekwipunek(Convert.ToInt32(temp[5]), Convert.ToInt32(temp[6]), Convert.ToInt32(temp[7]), Convert.ToInt32(temp[8]), Convert.ToInt32(temp[9]), temp[10], temp[11]);
                                        pancerz.pancerz(plecak.Pancerz, plecak.Poziom_Pancerza);
                                        bron.bron(plecak.Bron, plecak.Poziom_broni);
                                        Miasto miasto = new Miasto(wojak, plecak, bron, pancerz);
                                        break;
                                    }
                                case "Łotr":
                                    {
                                        lotr.bohater(temp[0], Convert.ToInt32(temp[2]), Convert.ToInt32(temp[3]), Convert.ToInt32(temp[4]), Convert.ToInt32(temp[4]));
                                        plecak.ekwipunek(Convert.ToInt32(temp[5]), Convert.ToInt32(temp[6]), Convert.ToInt32(temp[7]), Convert.ToInt32(temp[8]), Convert.ToInt32(temp[9]), temp[10], temp[11]);
                                        pancerz.pancerz(plecak.Pancerz, plecak.Poziom_Pancerza);
                                        bron.bron(plecak.Bron, plecak.Poziom_broni);
                                        Miasto miasto = new Miasto(lotr, plecak, bron, pancerz);
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;
                        }
                    case 2:
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
