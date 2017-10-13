using System;
using System.Collections.Generic;
using Strategy;

namespace TMB
{
    public class SeansasSpecialiKainaFilmoRodymas2D : Seansas
    {
        public SeansasSpecialiKainaFilmoRodymas2D(DateTime laikas, Filmas filmas, Sale sale)
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
        
        protected override void RodytiFilma(Filmas filmas)
        {
            Console.WriteLine("Rodomas filmas " + filmas.Pavadinimas + " 2D formatu");
        }

        protected override void PatikrintiBilietus(List<Bilietas> bilietai)
        {
            Console.WriteLine("Bilietai patikrinti");
        }

        protected override void SuleistiZiurovus()
        {
            Console.WriteLine("Žiūrovai suleisti");
        }
    }
}