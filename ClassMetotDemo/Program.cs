using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 10;
            musteri1.Ad = "Onur";
            musteri1.Soyad = "Özdemir";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 20;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Al";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 30;
            musteri3.Ad = "Mehmet";
            musteri3.Soyad = "Kaya";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            
        }



    }
}
