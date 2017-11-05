using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EQFBL
{
    class Zapisz
    {
        public Zapisz(Bohater bohater, Ekwipunek plecak)
        {
            string tmp;

            if (File.Exists(@"Zapis/bohaterowie.txt"))
            {
                File.AppendAllText(@"Zapis/bohaterowie.txt", bohater.Nazwa + " " + bohater.Klasa + " ");
            }
            else
            {
                using (StreamWriter file = new StreamWriter(@"Zapis/bohaterowie.txt"))
                {
                    tmp = bohater.Nazwa + " " + bohater.Klasa + " ";
                    file.Write(tmp);
                }
            }
            using (StreamWriter file = new StreamWriter("Zapis/" + bohater.Nazwa + ".txt"))
            {
                tmp = bohater.Nazwa + " " + bohater.Klasa + " " + bohater.Max_zycie + " " + bohater.Zycie + " " + bohater.Stamina;
                file.WriteLine(tmp);
            }

            using (StreamWriter file2 = new StreamWriter(@"Zapis/" + bohater.Nazwa + "_Plecak.txt"))
            {
                tmp = plecak.Poziom_plecaka + " " + plecak.Kasa + " " + plecak.Ile_potionow + " " + plecak.Poziom_broni + " " + plecak.Poziom_Pancerza + " " + plecak.Bron + " " + plecak.Pancerz;
                file2.WriteLine(tmp);
            }
        }
    }
}
