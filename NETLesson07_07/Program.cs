using System;
using System.Collections.Generic;

namespace NETLesson07_07
{
    /* Sukurti 2 struktūras Gyvūnas ir ZoologijosSodas.
     * Gyvūnas turi vardą ir rūšį.
     * Zoologijos sodas turi pavadinimą adresą ir gyvūnų sąrašą. 
     * Zoologijos sodas turi „mokėti pasakyti“ kiek viso gyvūnų yra, kiek kokios rūšies gyvūnų yra. */

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Gyvunas> gyvunai = new List<Gyvunas>();
            Gyvunas gyvunas = new Gyvunas("Lava", "Kate");
            Gyvunas gyvunas1 = new Gyvunas("Bertas", "Suo");
            gyvunai.Add(gyvunas);
            gyvunai.Add(gyvunas1);

            ZoologogijosSodas zoologogijosSodas = new ZoologogijosSodas("Kaunas", "Vetru g.", gyvunai);
            
        }

        struct Gyvunas
        {
            public string Vardas;
            public string Rusys;

            public Gyvunas(string vardas, string rusys)
            {
                Vardas = vardas;
                Rusys = rusys;
            }
        }

        struct ZoologogijosSodas
        {
            public string Pavadinimas;
            public string Adresas;
            public List<Gyvunas> GyvunuSarasas;

            public ZoologogijosSodas(string pavadinimas, string adreasas, List<Gyvunas> gyvunuSarasas)
            {
                Pavadinimas = pavadinimas;
                Adresas = adreasas;
                GyvunuSarasas = gyvunuSarasas;
            }

            static int GyvunuSkaicius()
            {
                return 0;
            }
            static string GyvunuRusys()
            {
                return "kazkas";
            }  
        }
    }
}
