using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Lotr : Bohater
    {
        protected int pocz_max_zycie = 100, pocz_max_stamina = 100;

        public void lotr()
        {
            Ograniczenia();
        }

        protected override void Ograniczenia()
        {
            dostepna_bron[0] = "sztylet";
            dostepna_bron[1] = "miecz";
            dostepny_pancerz[0] = "lekki";
            dostepny_pancerz[1] = "średni";          
        }
        protected override void Nazwa_klasy()
        {
            klasa = "Łotr";
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
