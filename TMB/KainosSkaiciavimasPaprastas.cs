using System;
using System.Collections;

namespace Strategy
{
    public class KainosSkaiciavimasPaprastas : IKainosSkaiciavimas
    {
        public int TikrintiSale(Sale sale)
        {
            return (sale.Savikaina / sale.VietuSk) * 100;
        }

        public int TikrintiLaika(DateTime laikas)
        {
            if ((laikas - DateTime.Now).TotalHours < 2)
                return -100;
            return 0;
        }

        public int TaikytiNuolaida(int nuolaidosKodas, int kaina)
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