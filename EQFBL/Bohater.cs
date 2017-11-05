using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    abstract class Bohater : Interface
    {
        protected string nazwa, klasa;
        protected double max_zycie, max_stamina;
        protected double zycie, stamina;
        protected bool czy_zyje = true;

        protected string[] dostepna_bron = new string[3];
        protected string[] dostepny_pancerz = new string[3];


        public void bohater(string nazwa, int max_zycie, int zycie, double max_stamina, int stamina)
        {
            this.nazwa = nazwa;
            this.max_zycie = max_zycie;
            this.zycie = zycie;
            this.max_stamina = max_stamina;
            this.stamina = stamina;

            Nazwa_klasy();
            Ograniczenia();
            Umiejetnosci();
        }

        protected abstract void Nazwa_klasy();
        protected abstract void Umiejetnosci();
        protected abstract void Ograniczenia();

        public virtual Array Zwroc_ograniczenia_broni
        {
            get { return dostepna_bron; }
        }
        public virtual Array Zwroc_ograniczenia_pancerzy
        {
            get { return dostepny_pancerz; }
        }

        public double Zycie
        {
            get { return zycie; }
        }
        public string Nazwa
        {
            get { return nazwa; }
        }
        public string Klasa
        {
            get { return klasa; }
        }
        public double Max_zycie
        {
            get { return max_zycie; }
            set { max_zycie = value; }
        }
        public double Max_stamina
        {
            get { return max_stamina; }
            set { max_stamina = value; }
        }
        public double Stamina
        {
            get { return stamina; }
        }
        public bool Czy_Zyje
        {
            get { return czy_zyje; }
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
        public void Zmecznie(int wartosc)
        {
            if (stamina - wartosc > 0)
            {
                stamina = stamina - wartosc;
            }
            else
            {
                stamina = 0;
            }
        }
        public void Regeneracja_staminy(double wartosc)
        {
            if (stamina + wartosc < max_stamina)
            {
                stamina = stamina + wartosc;
            }
            else
            {
                stamina = max_stamina;
            }
        }
        public void Regeneracja_zycia(int wartosc)
        {
            if (zycie + wartosc < max_zycie)
            {
                zycie = zycie + wartosc;
            }
            else
            {
                zycie = max_zycie;
            }
        }
    }
}