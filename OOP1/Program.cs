using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//2 Mobilyaya karşılık gelsin örnek olarak.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            Product product2 = new Product
            {
                Id=2,
                CategoryId=5,
                ProductName="Kalem",
                UnitsInStock=5,
                UnitPrice=35
            };
            //PascalCase   CamelCase
            //Case Sensitive Küçük büyük harfe duyarlıdır C#.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //int,double,bool,decimal,float... değer tiptir.
            //Arrayler,class,abstract class,interface referans tiptir.
        }
    }
}
