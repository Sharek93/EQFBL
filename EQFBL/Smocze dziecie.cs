using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Smocze_dziecie : Potwor
    {
        protected override void Nadaj_nazwe()
        {
            nazwa = "Smoczy dzieć";
        }

        protected override void Oblicz_obrazenia_potwora()
        {
            obrazenia = poziom * 6;
        }

        protected override void Oblicz_zycie_potwora()
        {
            zycie = poziom * 100;
        }

        protected override void Oblicz_kase_z_potwora()
        {
            kasa = poziom * 10;
        }
    }
}
