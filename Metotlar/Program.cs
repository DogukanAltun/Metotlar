using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Urun1 = new Product();
            Urun1.Adi = "Elma";
            Urun1.Acıklama = "Amasya Elması";
            Urun1.Fiyati = 15;

            Product Urun2 = new Product();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 80;
            Urun2.Acıklama = "Diyarbakır Karpuzu";

            Product[] Urunler = new Product[] { Urun1, Urun2 };

            foreach ( var  Urun in Urunler)
            {
                Console.WriteLine(Urun.Adi +": "+ Urun.Acıklama +", Fiyatı "+ Urun.Fiyati);
                Console.WriteLine("-------------------------------------");
            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);

        }
    }
}
