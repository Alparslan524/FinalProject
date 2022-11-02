using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
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
            ProductManager productManager = new ProductManager(new EfProductDal());
            void ListeleGetAll()
            {
                foreach (var p in productManager.GetAll())
                {
                    Console.WriteLine("Ürün Adı: " + p.ProductName + "\n" + "Ürün Fiyatı: " + p.UnitPrice +
                    "\n" + "Ürün Stoğu: " + p.UnitsInStock + "\n" + "******************");
                }
            };
            //ListeleGetAll();
            



            void ListeleGetAllUnitPrice(decimal min ,decimal max)
            {
                foreach (var p in productManager.GetAllUnitPrice(min,max))
                {
                    Console.WriteLine("Ürün Adı: " + p.ProductName + "\n" + "Ürün Fiyatı: " + p.UnitPrice +
                    "\n" + "Ürün Stoğu: " + p.UnitsInStock + "\n" + "******************");
                }
            };
            //ListeleGetAllUnitPrice(50,100);

            void ListeleGetAllByCategoryId(int id)
            {
                foreach (var p in productManager.GetAllByCategoryId(id))
                {
                    Console.WriteLine("Ürün Adı: " + p.ProductName + "\n" + "Ürün Fiyatı: " + p.UnitPrice +
                    "\n" + "Ürün Stoğu: " + p.UnitsInStock + "\n" + "******************");
                }
            };
            //ListeleGetAllByCategoryId(2);



            //ürün ekliyoruz
            //Product product = new Product
            //{
            //     CategoryID = 3, ProductName = "Laptop", UnitPrice = 6500, UnitsInStock = 7
            //};
            //productManager.Add(product);
            //Listele();


        }
    }
}
