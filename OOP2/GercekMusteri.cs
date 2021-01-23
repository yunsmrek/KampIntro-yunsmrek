using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gerçek müşteride bir müşteridir
    class GercekMusteri:Musteri//Individual(Bireysel) :Musteri inheritancedır
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }//matematiksel işlem yapmıyosan string

    }
}
