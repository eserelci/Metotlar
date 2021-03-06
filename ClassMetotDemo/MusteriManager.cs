using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi:" + musteri.Ad + "\n");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi:"+musteri.Ad + "\n");
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı:"+ musteri.Ad + "\n");
                Console.WriteLine("Müşteri Soyadı:" + musteri.Soyad + "\n");
                Console.WriteLine("Müşteri Soyadı:" + musteri.Yas + "\n");
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
