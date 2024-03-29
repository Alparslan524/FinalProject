﻿using Business.Concrete;
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

            ProductManager productManager = new ProductManager(new EfProductDal());

            //var result = productManager.GetAll();
            //if (result.Success==true)
            //{
            //    foreach (var p in productManager.GetAll().Data)
            //    {
            //        Console.WriteLine("Ürün Adı: " + p.ProductName + "\n" + "Ürün Fiyatı: " + p.UnitPrice +
            //        "\n" + "Ürün Stoğu: " + p.UnitsInStock + "\n" + "******************");
            //    }
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            
            
            
            void UrunListeleGetAll()
            {
                foreach (var p in productManager.GetAll().Data)
                {
                    Console.WriteLine("Ürün Adı: " + p.ProductName + "\n" + "Ürün Fiyatı: " + p.UnitPrice +
                    "\n" + "Ürün Stoğu: " + p.UnitsInStock + "\n" + "******************");
                }
            };
            //UrunListeleGetAll();

            void UrunListeleGetAllUnitPrice(decimal min ,decimal max)
            {
                foreach (var p in productManager.GetAllUnitPrice(min,max).Data)
                {
                    Console.WriteLine("Ürün Adı: " + p.ProductName + "\n" + "Ürün Fiyatı: " + p.UnitPrice +
                    "\n" + "Ürün Stoğu: " + p.UnitsInStock + "\n" + "******************");
                }
            };
            //UrunListeleGetAllUnitPrice(50,100);

            //void UrunListeleGetAllByCategoryId(int id)
            //{
            //    var result = productManager.GetAll();
            //    if (result.Success == true)
            //    {
            //        foreach (var p in productManager.GetAllByCategoryId(id).Data)
            //        {
            //            Console.WriteLine("Ürün Adı: " + p.ProductName + "\n" + "Ürün Fiyatı: " + p.UnitPrice +
            //            "\n" + "Ürün Stoğu: " + p.UnitsInStock + "\n" + "******************");
            //        }
            //        Console.WriteLine(result.Message);
            //    }
            //    else
            //    {
            //        Console.WriteLine(result.Message);
            //    }
            //};
            //UrunListeleGetAllByCategoryId(1);

            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //void CategoryListele()
            //{
            //    foreach (var c in categoryManager.GetAll())
            //    {
            //        Console.WriteLine("Category Adı: " + c.CategoryName);
            //    }
            //};
            //CategoryListele();

            //void UrunListe2leGetAll()
            //{
            //    foreach (var p in productManager.GetProductDetailDtos().Data)
            //    {
            //        Console.WriteLine("Ürün Adı: " + p.ProductName +"\n" 
            //            + "Category İsmi: " + p.CategoryName + "\n" + "******************");//Sadece DTO ya eklediklerimizi yazabildik
            //                                                                                //yani productıd-productname-categoryname-unitinstock yazabiliriz.
            //                                                                                //çünkü .GetProductDetailDtos çağırdık
            //    }
            //};
            //UrunListe2leGetAll();

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
