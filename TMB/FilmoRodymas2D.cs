using System;
using System.Collections.Generic;
using Strategy;

namespace StrategyB
{
    public class FilmoRodymas2D : IFilmoRodymas
    {
        public void RodytiFilma(Filmas filmas)
        {
            Console.WriteLine("Rodomas filmas " + filmas.Pavadinimas + " 2D formatu");
        }

        public void PatikrintiBilietus(List<Bilietas> bilietai)
        {
            Console.WriteLine("Bilietai patikrinti");
        }

        public void SuleistiZiurovus()
        {
            Console.WriteLine("Žiūrovai suleisti");
        }
    }
}