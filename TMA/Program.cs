using System;
using System.Text;
using Strategy;
using TM;

namespace TMA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Filmas filmas = new Filmas();
            Sale sale = new Sale();
            sale.Savikaina = 100;
            sale.VietuSk = 100;
            
            Seansas seansas1 = new SeansasPaprastaKaina(new DateTime(2017, 10, 14, 18, 0, 0), filmas, sale);
            Seansas seansas2 = new SeansasSpecialiKaina(new DateTime(2017, 10, 14, 20, 0, 0), filmas, sale);

			Console.OutputEncoding = Encoding.UTF8;
			PirktiBilieta(seansas1, 4);
            PirktiBilieta(seansas1, 2);
            PirktiBilieta(seansas2, 4);
            PirktiBilieta(seansas2, 2);
            
            Renginys renginys1 = new RenginysPaprastaKaina("Opera", new DateTime(2017, 10, 14, 18, 00, 00), sale);
            Renginys renginys2 = new RenginysSpecialiKaina("Opera", new DateTime(2017, 10, 14, 20, 00, 00), sale);
            
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