using System;
using System.Text;
using Strategy;

namespace StrategyA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Filmas filmas = new Filmas();
            Sale sale = new Sale();
            sale.Savikaina = 100;
            sale.VietuSk = 100;
            KainosSkaiciavimasPaprastas ksp = new KainosSkaiciavimasPaprastas();
            KainosSkaiciavimasSpecialus kss = new KainosSkaiciavimasSpecialus();
            Seansas seansas1 = new Seansas(new DateTime(2017, 10, 14, 18, 0, 0), filmas, sale, ksp );
            Seansas seansas2 = new Seansas(new DateTime(2017, 10, 14, 20, 0, 0), filmas, sale, kss );

	        Console.OutputEncoding = Encoding.UTF8;
			PirktiBilieta(seansas1, 4);
            PirktiBilieta(seansas1, 2);
            PirktiBilieta(seansas2, 4);
            PirktiBilieta(seansas2, 2);
            
            Renginys renginys1 = new Renginys("Opera", new DateTime(2017, 10, 14, 18, 00, 00), sale, ksp);
            Renginys renginys2 = new Renginys("Opera", new DateTime(2017, 10, 14, 20, 00, 00), sale, kss);
            
            PirktiBilieta(renginys1, 4);
            PirktiBilieta(renginys1, 2);
            PirktiBilieta(renginys2, 4);
            PirktiBilieta(renginys2, 2);
	        Console.Read();
		}

        private static void PirktiBilieta(Seansas seansas, int nuolaida)
        {
            int kaina = seansas.SkaiciuotiKaina(nuolaida);
			Console.WriteLine("Parduotas bilietas už " + (kaina / 100) + "." + kaina % 100);
		}
        
        private static void PirktiBilieta(Renginys renginys, int nuolaida)
        {
            int kaina = renginys.SkaiciuotiKaina(nuolaida);
			Console.WriteLine("Parduotas bilietas už " + (kaina / 100) + "." + kaina % 100);
		}
    }
}