using System;
using System.Collections.Generic;
using Strategy;

namespace TM
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

        protected abstract int TikrintiSale(Sale sale);

        protected abstract int TikrintiLaika(DateTime laikas);

        protected abstract int TaikytiNuolaida(int nuolaidosKodas, int kaina);
        
    }
}