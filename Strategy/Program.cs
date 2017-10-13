using System;
using System.Text;

namespace Strategy
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
	        Console.Read();
        }

        private static void PirktiBilieta(Seansas seansas, int nuolaida)
        {
            int kaina = seansas.SkaiciuotiKaina(nuolaida);
            Console.WriteLine("Parduotas bilietas už " + (kaina/100) + "." + kaina%100);
        }
    }
}