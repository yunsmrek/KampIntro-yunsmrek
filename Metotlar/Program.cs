using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //class ın örneği class olduğu için new yazman gerek
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 44;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 11;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe - tip güvenliği/ Urun yerine var da yazılsa oluyo
            //cs=c#
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }

            Console.WriteLine("----------Metotlar----------");
            //instance - örnek
            //encapsulation(kapsülleme) - koda ekleme yapınca kodun patlaması

            SepetManager sepetManager = new SepetManager();//class örneği
            sepetManager.Ekle(urun1);//cw tab tab yap console writelineı yazar
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 22,10);
            sepetManager.Ekle2("Antep Fıstığı", "Gaziantep", 71,21);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 42,61);
        }
    }

}



/* Don't Repeat Yourself - DRY - Clean Code - Best Practice=En iyi uygulama taktikleri

*/