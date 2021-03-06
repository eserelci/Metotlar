using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        //naming convention -- İsimlendirme
        //syntax -- yazım şekilleri
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler.Sepete eklendi:"+urun.Adi+ "Stok Adedi:" + urun.Stokadedi+"\n");
        }
        //Ekle2 Metodu kullanışsız sonradan değiştirmesi zor bir metottur.
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokadedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi:" + urunAdi + "Stok Adedi:"+stokadedi+"\n");
        }
    }
}
