using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[]
           {
                "karpuz","elma"
           };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati=15;
            urun1.Aciklama = "Amasya Elması";
            urun1.Stokadedi = 5;
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "İzmir Karpuzu";
            urun2.Stokadedi = 6;
            Urun[] urunler = new Urun[] { urun1,urun2 };
            //type-safe --tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı:" + urun.Adi + " " + "Ürün Fiyatı:" + urun.Fiyati + " " + "Ürün Açıklaması:" + urun.Aciklama + "\n");
            }
            Console.WriteLine("--------Metotlar--------");
            //instance -- class örneği oluşturmak
            SepetManager sepetManager = new SepetManager();
            //Metotlar reusability sağlar.
            //Aşağıdaki gibi classların eklenmesi encapsulation olayı denir.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yeşil Armut",12,8);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,8);
            sepetManager.Ekle2("Karpuz", "İzmir Karpuzu", 12,8);
        }
    }
}
//Metotlar tekrar tekrar kullanılabilirliği sağlar. Don't repeat yourself- Clean Code - Best Practice prensibi.