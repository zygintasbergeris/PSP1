using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Renginys
    {
        private string pavadinimas;
        private DateTime laikas;
        private Sale sale;
        private List<Bilietas> bilietai;
        private IKainosSkaiciavimas ks;

        public Renginys(string pavadinimas, DateTime laikas, Sale sale, IKainosSkaiciavimas ks)
        {
            this.pavadinimas = pavadinimas;
            this.laikas = laikas;
            this.sale = sale;
            this.ks = ks;
        }
        
        public int SkaiciuotiKaina(int nuolaida)
        {
            int kaina = 1000;
            kaina += ks.TikrintiSale(sale);
            kaina += ks.TikrintiLaika(laikas);
            kaina = ks.TaikytiNuolaida(nuolaida, kaina);
            return kaina;
        }
    }
}