using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(Convert.ToString(sayi1));
            //sayi1 = 30 olurdu anlık değer tuttuğu için 
            
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(Convert.ToString(sayilar1[0]));
            //sayilar1[0]=999 olur referans olarak saklandığı için
            
            
            /*stack-heap olayından dolayı
            array class interface abstractlar ref tip olarak saklanır 
            stackta sayilar1 olur değerler heap te saklıdır.
            stack te heap in adresi saklanır.
            ind double bool vb.(sayısal veri tipleri) değer tiplidir stack te kalır heap e yazılmaz.
            heapteki değerler eğer stackte bir adreste saklanmıyorsa 
            Garbage collector heapteki değeri siler.
             */
        }
    }
}
