﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Yunus";
            int Yas = 22;

            Kurs kurs1 = new Kurs();//kurs1 inin tipi kurs // class değişkeni tutma
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 47;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Yunus Emre Kılıç";
            kurs3.IzlenmeOrani = 61;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "JavaScript";
            kurs4.Egitmen = "Ömer Faruk Gençkan";
            kurs4.IzlenmeOrani = 19;


            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs kurss in kurslar)
            {
                Console.WriteLine(kurss.KursAdi + " :" + kurss.Egitmen + " %" + kurss.IzlenmeOrani);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }//prop=property özellik prop yaz tab tab yap
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
