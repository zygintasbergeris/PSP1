using System;
using System.Collections.Generic;
using Strategy;

namespace TMB
{
    public class SeansasPaprastaKainaFilmoRodymas3D : Seansas
    {
        public SeansasPaprastaKainaFilmoRodymas3D(DateTime laikas, Filmas filmas, Sale sale)
        {
            this.laikas = laikas;
            this.filmas = filmas;
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
        
        protected override void RodytiFilma(Filmas filmas)
        {
            Console.WriteLine("Rodomas filmas " + filmas.Pavadinimas + " 3D formatu");
        }
        
        protected override void PatikrintiBilietus(List<Bilietas> bilietai)
        {
            Console.WriteLine("Bilietai patikrinti");
        }

        protected override void SuleistiZiurovus()
        {
            IsdalintiAkinius();
            Console.WriteLine("Žiūrovai suleisti ir akiniai išdalinti");
        }

        private void IsdalintiAkinius()
        {
            
        }
    }
}