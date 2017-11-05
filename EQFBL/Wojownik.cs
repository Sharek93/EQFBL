using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Wojownik : Bohater
    {
        protected int pocz_max_zycie = 200, pocz_max_stamina = 50;

        public void wojownik()
        {
            Ograniczenia();
        }

        protected override void Ograniczenia()
        {
            dostepna_bron[0] = "miecz";
            dostepna_bron[1] = "buława";
            dostepna_bron[2] = "topór";
            dostepny_pancerz[0] = "śrdeni";
            dostepny_pancerz[1] = "ciężki";
        }
        protected override void Nazwa_klasy()
        {
            klasa = "Wojownik";
        }

        public override Array Zwroc_ograniczenia_broni
        {
            get { return dostepna_bron; }
        }
        public override Array Zwroc_ograniczenia_pancerzy
        {
            get { return dostepny_pancerz; }
        }

        public int Zwroc_pocz_zycie
        {
            get { return pocz_max_zycie; }
        }
        public int Zwroc_pocz_stamine
        {
            get { return pocz_max_stamina; }
        }

        protected override void Umiejetnosci()
        {
            
        }
    }
}
