using System;
using Strategy;

namespace TMA
{
    public class RenginysPaprastaKaina : Renginys
    {
        public RenginysPaprastaKaina(string pavadinimas, DateTime laikas, Sale sale)
        {
            this.pavadinimas = pavadinimas;
            this.laikas = laikas;
            this.sale = sale;
        }
        
        protected override int TikrintiSale(Sale sale)
        {
            return sale.Savikaina / sale.VietuSk * 100;
        }

        protected override int TikrintiLaika(DateTime laikas)
        {
            if ((laikas - DateTime.Now).TotalHours < 2)
                return -100;
            return 0;
        }

        protected override int TaikytiNuolaida(int nuolaidosKodas, int kaina)
        {
            switch (nuolaidosKodas)
            {
                case 1: return Convert.ToInt32(kaina * 0.9);
                case 2: return Convert.ToInt32(kaina * 0.8);
                case 3: return Convert.ToInt32(kaina * 0.95);
                case 4: return Convert.ToInt32(kaina * 0.85);
                default : break;
            }
            return kaina;
        }
    }
}