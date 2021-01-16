using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention // syntax - yazım tipi
        public void Ekle(Urun urun)//normal parantez metot çalışıyor demek / urun = parametre
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : "+ urun.Adi +" "+urun.StokAdedi+ " adet kaldı");

        }
        
        public void Ekle2(string urunAdi,string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi+" " + stokAdedi + " adet kaldı");
        }
    }
}
