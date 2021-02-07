using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriNo = "1234567890";
            musteri1.Adi = "Hansel";
            musteri1.Soyadi = "German";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriNo = "1456787654";
            musteri2.Adi = "Gratel";
            musteri2.Soyadi = "German";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriNo = "123367890";
            musteri3.Adi = "Erkan";
            musteri3.Soyadi = "Ergen";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();


            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Musteri[] musteri = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriSil(musteri1);
        }
    }
}
