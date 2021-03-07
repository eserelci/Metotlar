using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Snippet hazır kodlar demektir.
    public class Product
    {
        public int Id { get; set; }//Primary Key Referansıdır.
        public int CategoryId { get; set; } //Foreign Key Referans Alanı.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        //CRUD Create Update Delete İşlemleri olabilir.
    }
}
