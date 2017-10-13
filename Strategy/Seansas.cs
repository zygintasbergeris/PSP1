using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Seansas
    {
        private DateTime laikas;
        private List<Bilietas> bilietai;
        private Filmas filmas;
        private Sale sale;
        private IKainosSkaiciavimas ks;

        public Seansas(DateTime laikas, Filmas filmas, Sale sale, IKainosSkaiciavimas ks)
        {
            this.laikas = laikas;
            this.filmas = filmas;
            this.sale = sale;
            this.ks = ks;
        }
        
        public int SkaiciuotiKaina(int nuolaida)
        {
            int kaina = 500;
            kaina += ks.TikrintiSale(sale);
            kaina += ks.TikrintiLaika(laikas);
            kaina = ks.TaikytiNuolaida(nuolaida, kaina);
            return kaina;
        }
    }
}