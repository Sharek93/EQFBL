using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQFBL
{
    class Szkieletor : Potwor
    {
        protected override void Nadaj_nazwe()
        {
            nazwa = "Szkieletor";
        }

        protected override void Oblicz_obrazenia_potwora()
        {
            obrazenia = poziom * 4;
        }

        protected override void Oblicz_zycie_potwora()
        {
            zycie = poziom * 20;
        }

        protected override void Oblicz_kase_z_potwora()
        {
            kasa = poziom * 2;
        }
    }
}
