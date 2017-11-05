using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Ekwipunek
    {
        protected int kasa, max_kasa, ile_potionow, ile_max_potionow;
        protected int poziom_plecaka, poziom_broni, poziom_pancerza;
        protected string bron, pancerz;

        public void ekwipunek(int poziom_plecaka, int kasa, int ile_potionow, int poziom_broni, int poziom_pancerza, string bron, string pancerz)
        {
            this.kasa = kasa;
            this.ile_potionow = ile_potionow;
            this.poziom_plecaka = poziom_plecaka;
            this.poziom_broni = poziom_broni;
            this.poziom_pancerza = poziom_pancerza;
            this.bron = bron;
            this.pancerz = pancerz;

            ile_max_potionow = 1 + poziom_plecaka / 2;
            max_kasa = poziom_plecaka * 100;

            if (ile_potionow > ile_max_potionow)
            {
                this.ile_potionow = ile_max_potionow;
            }
            if (kasa > max_kasa)
            {
                this.kasa = max_kasa;
            }
        }

        public void Przelicz_plecak(int poziom_plecaka)
        {
            ile_max_potionow = 1 + poziom_plecaka / 2;
            max_kasa = poziom_plecaka * 100;
        }

        public int Poziom_plecaka
        {
            get { return poziom_plecaka; }
            set { poziom_plecaka = value; }
        }
        public int Kasa
        {
            get { return kasa; }
        }
        public int Max_kasa
        {
            get { return max_kasa; }
        }
        public int Ile_potionow
        {
            get { return ile_potionow; }
        }
        public int Ile_max_potionow
        {
            get { return ile_max_potionow; }
        }
        public int Poziom_broni
        {
            get { return poziom_broni; }
            set { poziom_broni = value; }
        }
        public int Poziom_Pancerza
        {
            get { return poziom_pancerza; }
            set { poziom_pancerza = value; }
        }
        public string Pancerz
        {
            get { return pancerz; }
            set { pancerz = value; }
        }
        public string Bron
        {
            get { return bron; }
            set { bron = value; }
        }
        public void Zysk(int warosc)
        {
            if(kasa + warosc < max_kasa)
            {
                kasa = kasa + warosc;
            }
            else
            {
                kasa = max_kasa;
            }
        }
        public void Wydatek(int wartosc)
        {
            if (kasa - wartosc > 0)
            {
                kasa = kasa - wartosc;
            }
            else
            {
                kasa = 0;
            }
        }
        public void plus_potion()
        {
            if (ile_potionow + 1 < ile_max_potionow)
            {
                ile_potionow++;
            }
            else
            {
                ile_potionow = ile_max_potionow;
            }
        }
        public void minus_potion()
        {
            if (ile_potionow - 1 > 0)
            {
                ile_potionow--;
            }
            else
            {
                ile_potionow = 0;
            }
        }
    }
}
