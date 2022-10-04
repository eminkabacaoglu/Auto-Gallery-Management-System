using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleri_G007
{
    class Araba
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiralamaBedeli { get; set; }
        public ARAC_TIPI AracTipi { get; set; }


        public DURUM Durum { get; set; }
        public List<DateTime> KiralanmaTarihleri { get; set; }
        public List<int> KiralamaSureleri { get; set; }


        public Araba()
        {
            KiralanmaTarihleri = new List<DateTime>();
            KiralamaSureleri = new List<int>();
        }

        public Araba(string plaka)
        {
            KiralanmaTarihleri = new List<DateTime>();
            KiralamaSureleri = new List<int>();
        }


    }



    public enum DURUM
    {
        Kirada,
        Galeride,
        Serviste
    }
    public enum ARAC_TIPI
    {
        Sedan,
        SUV,
        Hatchpack
    }


}
