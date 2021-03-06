using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Urun
    {
        //Sınıfın ilk harfi büyük yazılır.Pascal Case.
        //Property -- O classın özelliklerini tutmak için kullanırız.
        public int Id { get; set; } //Kullandığımız eşşiz değerdir. Ayırmak için kullanırız.
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int Stokadedi { get; set; }
    }
}
