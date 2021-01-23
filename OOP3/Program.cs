using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            // yukarı 3 lü ekrandaki açılır kutular seçilebilen kredi türleri gibi düşün
            //ınterface lerde onu implemente eden class ların ref ini tutabilir.

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasıtKrediManager);
            basvuruManager.BasvuruYap(new EsnafKrediManager(),new SmsLoggerService());
            //yaptığımız iş soyutlama

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
