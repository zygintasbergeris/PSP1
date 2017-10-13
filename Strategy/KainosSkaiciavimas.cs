using System;

namespace Strategy
{
    public interface IKainosSkaiciavimas
    {
        int TikrintiSale(Sale sale);

        int TikrintiLaika(DateTime laikas);

        int TaikytiNuolaida(int nuolaidosKodas, int kaina);
    }
}