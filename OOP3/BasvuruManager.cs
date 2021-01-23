using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)//içine bunu yazarsan istediğimiz krediyi içeri yollayabiliriz
        {
            //başvuran bilgilerini değerlendirme

            //KonutKrediManager konutKrediManager = new KonutKrediManager();// böyle yaparsan bütün başvuruları konuta bağımlı yaparsın
            krediManager.Hesapla();
            loggerService.Log();//hangi loglayıcı seçilmişse onu logla
        }
        
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
