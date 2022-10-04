using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleri_G007
{
    class OtoGaleri
    {
        public List<Araba> Arabalar { get; set; }

        public int ToplamKiralamaSayisi { get; }
        public int ToplamKiralamaSuresi { get; }
        public double Ciro { get; }


        public OtoGaleri()
        {
            Arabalar = new List<Araba>();
            SahteAracGir();
        }

        public void SahteAracGir()
        {


        }


        public void Kirala(ARAC_TIPI aracTipi, int sure)
        {



        }

        public void Kirala(string plaka, int sure)
        {
            Arabalar[0].Durum = DURUM.Kirada;
            // Bu metot çalıştığında, ilgili aracın içindeki özellikler düzenlenecek.

        }

        public void KiralamaSonlandir(string plaka)
        {
            //
            Arabalar[0].Durum = DURUM.Galeride;
        }


        public void ArabaEkle(string plaka, string marka, float kiralamaBedeli, string aracTipi)
        {
            //Sistem araba numaralarını kendisi otomatik olarak benzersiz şekilde versin
        }



        public bool KiralamayaUygun(ARAC_TIPI aracTipi)
        {
            //Bu metot, araç kiralama uygunsa true, değilse false döndürsün

            //   Arabalar[0].AracTipi == aracTipi

            return true;
        }
        public bool KiralamayaUygun(string plaka)
        {
            //Bu metot, araç kiralama uygunsa true, değilse false döndürsün
            return true;

        }


    }
}
