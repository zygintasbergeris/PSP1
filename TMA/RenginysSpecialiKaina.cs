using System;
using Strategy;

namespace TMA
{
    public class RenginysSpecialiKaina : Renginys
    {
        public RenginysSpecialiKaina(string pavadinimas, DateTime laikas, Sale sale)
        {
            this.pavadinimas = pavadinimas;
            this.laikas = laikas;
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