using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteriEkle)
        {
            Console.WriteLine(musteriEkle.Id +" No'lu Müşteri = "+musteriEkle.Ad +" " +musteriEkle.Soyad);
        }
        public void Sil(Musteri musteriSil)
        {
            Console.WriteLine(musteriSil.Id +" "+ musteriSil.Ad +" "+ musteriSil.Soyad +" Kişisi Bankamızın listesinden çıkarılmıştır");
        }
    }
}
