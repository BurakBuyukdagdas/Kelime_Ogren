using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ogren.Siniflar
{
    public class SoruCecap
    {
        private static string _satir;
        private static string _soruTipi;
        private Random _random;
        public SoruCecap()
        {
            _random = new Random();
        }
        public void SoruyuSec()
        {
            if (DosyaIcerik.Icerik.Count == 0)
            {
                Console.WriteLine("Hata: Dosya içeriği boş. Lütfen önce bir dosya seçin.");
            }
            else
            {
                _satir = DosyaIcerik.Icerik[_random.Next(0, DosyaIcerik.Icerik.Count)];
            }
        }

        public string TurkceSoru()
        {
            var turkceSoru = _satir.Split('-')[1];
            //Text dosyasından soru çekerken - işareti ile ayırır.Text te 2. değer [1] olarak alır
            turkceSoru = KelimeleriBol(turkceSoru);
            _soruTipi = "Türkçe";
            return turkceSoru;
        }
        public string IngilizceSoru()
        {
            var ingilizceSoru = _satir.Split('-')[0];
            //Text dosyasından soru çekerken - işareti ile ayırır.Text te 1. değer [0] olarak alır
            ingilizceSoru = KelimeleriBol(ingilizceSoru);
            _soruTipi = "İngilizce";
            return ingilizceSoru;
        }
        public string KarisikSoru()
        {
            var randomSayi = _random.Next(0, 2);
            var karisikSoru = _satir.Split('-')[randomSayi];
            karisikSoru = KelimeleriBol(karisikSoru);
            if (randomSayi==0)
            {
                _soruTipi = "İngilizce";
            }
            else _soruTipi = "Türkçe";
            return karisikSoru;
        }
        public string KelimeleriBol(string kelimeler)
        {
            var bolunmusKelime = kelimeler.Split(',');
            var kelime = "";
            if (bolunmusKelime.Length > 1)
            {
                kelime = bolunmusKelime[_random.Next(0, 2)];
            }
            else kelime = bolunmusKelime[0];
            return kelime;
        }
        public string[] SorununCevabı()
        {
            string cevap = "";

            if (_soruTipi=="Türkçe")
                cevap = _satir.Split('-')[0];
            else
                cevap= _satir.Split('-')[1];
            return cevap.Split(',');

            
        }
    }
}
