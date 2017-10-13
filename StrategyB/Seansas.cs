using System;
using System.Collections.Generic;
using Strategy;

namespace StrategyB
{
    public class Seansas
    {
        private DateTime laikas;
        private List<Bilietas> bilietai;
        private Filmas filmas;
        private Sale sale;
        private IFilmoRodymas fr;
        private IKainosSkaiciavimas ks;
        
        public Seansas(DateTime laikas, Filmas filmas, Sale sale, IKainosSkaiciavimas ks, IFilmoRodymas fr)
        {
            this.laikas = laikas;
            this.filmas = filmas;
            this.sale = sale;
            this.ks = ks;
            this.fr = fr;
        }

        public int SkaiciuotiKaina(int nuolaida)
        {
            int kaina = 500;
            kaina += ks.TikrintiSale(sale);
            kaina += ks.TikrintiLaika(laikas);
            kaina = ks.TaikytiNuolaida(nuolaida, kaina);
            return kaina;
        }
        
        public void Rodyti()
        {
            fr.PatikrintiBilietus(bilietai);
            fr.SuleistiZiurovus();
            fr.RodytiFilma(filmas);
        }
    }
}