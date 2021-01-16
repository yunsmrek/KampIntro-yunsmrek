using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Don't repeat yourself!!
            // type safety = tip güvenliği / değer tutucu - alias 
            
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }
            
            
        }
    }
}
