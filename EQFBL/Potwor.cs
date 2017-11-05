using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    abstract class Potwor : Interface
    {
        bool czy_zyje = true;
        protected int poziom, zycie, obrazenia, kasa, max_zycie;
        protected string nazwa;
        string[] tab_typ = { "Słaby", "Normalny", "Mocny" };
        int typ;

        public void potwor (int poziom)
        {
            this.poziom = poziom;
            Random rand = new Random();
            
            typ = rand.Next(0, 3);

            Nadaj_nazwe();
            Oblicz_obrazenia_potwora();
            Oblicz_zycie_potwora();
            Oblicz_kase_z_potwora();

            switch (typ)
            {
                case 0:
                    {
                        Slaby(obrazenia, zycie, kasa);
                        break;
                    }
                case 1:
                    {
                        Normalny(obrazenia, zycie, kasa);
                        break;
                    }
                case 2:
                    {
                        Mocny(obrazenia, zycie, kasa);
                        break;
                    }
            }

            max_zycie = zycie;
        }

        protected abstract void Nadaj_nazwe();
        protected abstract void Oblicz_zycie_potwora();
        protected abstract void Oblicz_obrazenia_potwora();
        protected abstract void Oblicz_kase_z_potwora();

        protected void Slaby(int obrazenia, int zycie, int kasa)
        {
            this.obrazenia = obrazenia / 2;
            this.zycie = zycie / 2;
            this.kasa = kasa;
        }
        protected void Normalny(int obrazenia, int zycie, int kasa)
        {
            this.obrazenia = obrazenia;
            this.zycie = zycie;
            this.kasa = kasa * 2;
        }
        protected void Mocny(int obrazenia, int zycie, int kasa)
        {
            this.obrazenia = obrazenia * 2;
            this.zycie = zycie * 2;
            this.kasa = kasa * 4;
        }

        public void Zadane_obrazenia(int wartosc)
        {
            if (zycie - wartosc > 0)
            {
                zycie = zycie - wartosc;
            }
            else
            {
                zycie = 0;
                czy_zyje = false;
            }
        }
        public bool Czy_zyje
        {
            get { return czy_zyje; }
        }

        public int Poziom
        {
            get { return poziom; }
        }
        public int Zycie
        {
            get { return zycie; }
        }
        public int Max_zycie
        {
            get { return max_zycie; }
        }
        public int Obrazenia
        {
            get { return obrazenia; }
        }
        public int Kasa
        {
            get { return kasa; }
        }
        public string Typ
        {
            get { return tab_typ[typ]; }
        }
        public string Nazwa
        {
            get { return nazwa; }
        }
    }
}
