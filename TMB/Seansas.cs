using System;
using System.Collections.Generic;
using Strategy;

namespace TMB
{
    public abstract class Seansas
    {
        protected DateTime laikas;
        protected List<Bilietas> bilietai;
        protected Filmas filmas;
        protected Sale sale;

        public int SkaiciuotiKaina(int nuolaida)
        {
            int kaina = 500;
            kaina += TikrintiSale(sale);
            kaina += TikrintiLaika(laikas);
            kaina = TaikytiNuolaida(nuolaida, kaina);
            return kaina;
        }

        public void Rodyti()
        {
            PatikrintiBilietus(bilietai);
            SuleistiZiurovus();
            RodytiFilma(filmas);
        }
        
        protected abstract int TikrintiSale(Sale sale);
        
        protected abstract int TikrintiLaika(DateTime laikas);

        protected abstract int TaikytiNuolaida(int nuolaidosKodas, int kaina);

        protected abstract void RodytiFilma(Filmas filmas);
        
        protected abstract void PatikrintiBilietus(List<Bilietas> bilietai);

        protected abstract void SuleistiZiurovus();
    }
}