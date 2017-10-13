using System;

namespace Strategy
{
    public class KainosSkaiciavimasSpecialus : IKainosSkaiciavimas
    {
        public int TikrintiSale(Sale sale)
        {
            return 0;
        }

        public int TikrintiLaika(DateTime laikas)
        {
            if ((laikas - DateTime.Now).TotalHours < 2)
                return 100;
            return 0;
        }

        public int TaikytiNuolaida(int nuolaidosKodas, int kaina)
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