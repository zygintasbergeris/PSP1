using System;
using System.Text;
using Strategy;

namespace TMB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Filmas filmas = new Filmas();
            Sale sale = new Sale();
            sale.Savikaina = 100;
            sale.VietuSk = 100;
            
            Seansas seansas1 = new SeansasPaprastaKainaFilmoRodymas2D(new DateTime(2017, 10, 14, 18, 0, 0), filmas, sale);
            Seansas seansas2 = new SeansasSpecialiKainaFilmoRodymas3D(new DateTime(2017, 10, 14, 20, 0, 0), filmas, sale);
            Seansas seansas3 = new SeansasPaprastaKainaFilmoRodymas3D(new DateTime(2017, 10, 14, 18, 0, 0), filmas, sale);
            Seansas seansas4 = new SeansasSpecialiKainaFilmoRodymas2D(new DateTime(2017, 10, 14, 20, 0, 0), filmas, sale);

			Console.OutputEncoding = Encoding.UTF8;
			PirktiBilieta(seansas1, 4);
            PirktiBilieta(seansas1, 2);
            PirktiBilieta(seansas2, 4);
            PirktiBilieta(seansas2, 2);
            PirktiBilieta(seansas3, 4);
            PirktiBilieta(seansas3, 2);
            PirktiBilieta(seansas4, 4);
            PirktiBilieta(seansas4, 2);
            
            seansas1.Rodyti();
            seansas2.Rodyti();
            seansas3.Rodyti();
            seansas4.Rodyti();
	        Console.Read();
		}
        
        private static void PirktiBilieta(Seansas seansas, int nuolaida)
        {
            int kaina = seansas.SkaiciuotiKaina(nuolaida);
			Console.WriteLine("Parduotas bilietas už " + (kaina / 100) + "." + kaina % 100);
		}
    }
}