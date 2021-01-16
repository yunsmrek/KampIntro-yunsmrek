using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Products Urun1 = new Products();
            Urun1.ProductCategory = "Makyaj";
            Urun1.ProductType = "Ruj";
            Urun1.ProductName = "Missha";

            Products Urun2 = new Products();
            Urun2.ProductCategory = "Elektronik";
            Urun2.ProductType = "Cep Telefonu";
            Urun2.ProductName = "Huawei Honor 7";

            Products Urun3 = new Products();
            Urun3.ProductCategory = "Ev&Mutfak Aletleri";
            Urun3.ProductType = "Blender";
            Urun3.ProductName = "Arzum Blender";
            Products[] Urunler = new Products[] { Urun1, Urun2, Urun3 };
            
            Console.WriteLine("Foreach ile");

            foreach (Products Uruns in Urunler)
            {
                Console.WriteLine(Uruns.ProductCategory + "-" + Uruns.ProductType + "-" + Uruns.ProductName);
            }

            Console.WriteLine("For ile");

            for (int i = 0; i < Urunler.Length; i++)
            {
               Console.WriteLine(Urunler[i].ProductCategory+ "*y" +Urunler[i].ProductType+ "*" +Urunler[i].ProductName);
            }

            Console.WriteLine("While ile");
            int j = 0;
            while (j<Urunler.Length)
            {
                Console.WriteLine(Urunler[j].ProductCategory + "*y" + Urunler[j].ProductType + "*" + Urunler[j].ProductName);
                j++;
            }
        }
    }
    class Products
    {
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string ProductCategory { get; set; }

    }
}
