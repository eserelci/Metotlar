using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "ESER";
            musteri1.Soyad = "ELÇİ";
            musteri1.Yas = 21;
            Musteri musteri2 = new Musteri();
            musteri2.Ad = "ELÇİM";
            musteri2.Soyad = "ELÇİ";
            musteri2.Yas = 21;
            Musteri[] musteriler = new Musteri[] {musteri1,musteri2};
            MusteriManager musteriManager = new MusteriManager();
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
            }
            musteriManager.MusteriListele(musteriler);
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriSil(musteri);
            }           
            Console.ReadLine();
        }
    }
}
