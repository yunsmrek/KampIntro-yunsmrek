using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs","Java","Python","C#" };
           
            /* array-dizi 
             tab tab = swipped - döngü iskeleti //for javada da aynı*/
            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Foreach e Geçiyoruz");
            foreach (string kurs in kurslar)//String class s si büyükse // dizi temlli yapıları tek tek dönmeye yarıyo foreach kodu
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
