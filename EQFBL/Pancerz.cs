using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Pancerz
    {
        string klasa_pancerza;
        int poziom_pancerza;
        protected int bonus_zycia, bonus_staminy, zycie_pancerza;

        public void pancerz(string klasa_pancerza, int poziom_pancerza = 1)
        {
            this.klasa_pancerza = klasa_pancerza;
            this.poziom_pancerza = poziom_pancerza;

            bonus_staminy_pacerza(klasa_pancerza);
            bonus_zycia_pacerza(klasa_pancerza, poziom_pancerza);

            zycie_pancerza = bonus_zycia;
        }

        public void Przelicz_pancerz(string klasa_pancerza, int poziom)
        {
            bonus_staminy_pacerza(klasa_pancerza);
            bonus_zycia_pacerza(klasa_pancerza, poziom);
        }

        private void bonus_zycia_pacerza(string klasa_pancerza, int poziom_pancerza)
        {
            switch (klasa_pancerza)
            {
                case "lekki":
                    {
                        bonus_zycia = poziom_pancerza * 10;
                        break;
                    }
                case "średni":
                    {
                        bonus_zycia = poziom_pancerza * 20;
                        break;
                    }
                case "ciężki":
                    {
                        bonus_zycia = poziom_pancerza * 40;
                        break;
                    }
            }
        }

        protected void bonus_staminy_pacerza(string klasa_pancerza)
        {
            switch (klasa_pancerza)
            {
                case "lekki":
                    {
                        bonus_staminy = 5;
                        break;
                    }
                case "średni":
                    {
                        bonus_staminy = 2;
                        break;
                    }
                case "ciężki":
                    {
                        bonus_staminy = 0;
                        break;
                    }
            }
        }

        public void Naprawa_pancerza()
        {
            zycie_pancerza = bonus_zycia;
        }

        public int Bonus_zycia
        {
            get { return bonus_zycia; }
        }
        public int Bonus_staminy
        {
            get { return bonus_staminy; }
        }

        public int Zycie_pancerza
        {
            get { return zycie_pancerza; }
        }

        public void Obrażenia_pancerza(int wartosc)
        {
            if (zycie_pancerza - wartosc > 0)
            {
                zycie_pancerza = zycie_pancerza - wartosc;
            }
            else
            {
                zycie_pancerza = 0;
            }
        }
    }
}
