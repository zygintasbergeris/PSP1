using System;
using Strategy;

namespace TM
{
    public class SeansasSpecialiKaina : Seansas
    {
        public SeansasSpecialiKaina(DateTime laikas, Filmas filmas, Sale sale)
        {
            this.laikas = laikas;
            this.filmas = filmas;
            this.sale = sale;
        }
        
        protected override int TikrintiSale(Sale sale)
        {
            return 0;
        }

        protected override int TikrintiLaika(DateTime laikas)
        {
            if ((laikas - DateTime.Now).TotalHours < 2)
                return 100;
            return 0;
        }

        protected override int TaikytiNuolaida(int nuolaidosKodas, int kaina)
        {
            switch (nuolaidosKodas)
            {
                case 1: return Convert.ToInt32(kaina * 0.9);
                case 2: return Convert.ToInt32(kaina * 0.8);
                default : break;
            }
            return kaina;
        }
    }
}