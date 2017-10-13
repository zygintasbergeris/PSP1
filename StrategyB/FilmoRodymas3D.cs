using System;
using System.Collections.Generic;
using Strategy;

namespace StrategyB
{
    public class FilmoRodymas3D : IFilmoRodymas
    {
        public void RodytiFilma(Filmas filmas)
        {
            Console.WriteLine("Rodomas filmas " + filmas.Pavadinimas + " 3D formatu");
        }

        public void PatikrintiBilietus(List<Bilietas> bilietai)
        {
            Console.WriteLine("Bilietai patikrinti");
        }

        public void SuleistiZiurovus()
        {
            IsdalintiAkinius();
            Console.WriteLine("Žiūrovai suleisti ir akiniai išdalinti");
        }

        private void IsdalintiAkinius()
        {
            
        }
    }
}