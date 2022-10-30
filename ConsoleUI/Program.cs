using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ürün listeledik
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            void Listele()
            {
                foreach (var p in productManager.GetAll())
                {
                    Console.WriteLine("Ürün Adı: " + p.ProductName + "\n" + "Ürün Fiyatı: " + p.UnitPrice +
                    "\n" + "Ürün Stoğu: " + p.UnitsInStock + "\n" + "******************");
                }
            };
            Listele();
            
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("***********************************************************************");

            //ürün ekliyoruz
            Product product = new Product
            {
                ProductID = 6, CategoryID = 3, ProductName = "Laptop", UnitPrice = 6500, UnitsInStock = 7
            };
            productManager.Add(product);
            Listele();
            
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("***********************************************************************");

            productManager.Delete(product);
            Listele();



        }
    }
}
