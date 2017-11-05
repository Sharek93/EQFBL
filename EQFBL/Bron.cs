using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Bron
    {
        string klasa_broni;
        int poziom_broni;
        protected int obrazenia_goly, obrazenia_zasloniety;
        protected int zmeczenie;

        public void bron(string klasa_broni, int poziom_broni = 1)
        {
            this.klasa_broni = klasa_broni;
            this.poziom_broni = poziom_broni;

            Obrazenia(klasa_broni, poziom_broni);
        }

        public void Przelicz_bron(string klasa, int poziom)
        {
            Obrazenia(klasa, poziom);
        }


        private void Obrazenia(string klasa_broni, int poziom_broni)
        {
            switch (klasa_broni)
            {
                case "sztylet":
                    {
                        zmeczenie = 10;
                        obrazenia_goly = poziom_broni * 10;
                        obrazenia_zasloniety = 0;
                        break;
                    }
                case "miecz":
                    {
                        zmeczenie = 15;
                        obrazenia_goly = poziom_broni * 12;
                        obrazenia_zasloniety = 0;
                        break;
                    }
                case "buława":
                    {
                        zmeczenie = 25;
                        obrazenia_goly = poziom_broni * 12;
                        obrazenia_zasloniety = obrazenia_goly / 4;
                        break;
                    }
                case "topór":
                    {
                        zmeczenie = 40;
                        obrazenia_goly = poziom_broni * 20;
                        obrazenia_zasloniety = obrazenia_goly / 3;
                        break;
                    }
            }
        }

        public int Zmeczenie
        {
            get { return zmeczenie; }
        }
        public int Obrazenia_goly
        {
            get { return obrazenia_goly; }
        }
        public int Obrazenia_zasloniety
        {
            get { return obrazenia_zasloniety; }
        }
    }
}
