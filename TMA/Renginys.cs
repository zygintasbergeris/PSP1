using System;
using System.Collections.Generic;
using Strategy;

namespace TMA
{
    public abstract class Renginys
    {
        protected string pavadinimas;
        protected DateTime laikas;
        protected Sale sale;
        protected List<Bilietas> bilietai;
        
        
        
        public int SkaiciuotiKaina(int nuolaida)
        {
            int kaina = 1000;
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