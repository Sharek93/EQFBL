using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Zombie : Potwor
    {
        protected override void Nadaj_nazwe()
        {
            nazwa = "Zombie";
        }

        protected override void Oblicz_obrazenia_potwora()
        {
            obrazenia = poziom * 2;
        }

        protected override void Oblicz_zycie_potwora()
        {
            zycie = poziom * 40;
        }

        protected override void Oblicz_kase_z_potwora()
        {
            kasa = poziom * 2;
        }
    }
}
