using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;//Veritabanı gibi
        public InMemoryProductDal()
        {
            //Veritabanından veri eklemişiz gibi simüle ettik
            _products = new List<Product>
            {
                new Product{ProductID=1,CategoryID=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductID=2,CategoryID=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductID=3,CategoryID=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductID=4,CategoryID=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductID=5,CategoryID=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LİNQ
            // foreach gibi _products ın elemanlarını dolaştı ve dolaşırken ProdductID si parametre olarak gönderdiğimiz
            //productın ProductId sine eşit olanı YANİ silmek istediğimizin ProductID sine eşit olunca onu 
            //tempProduct nesnesine atadı. Daha sonra sildik
            Product tempProductDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);
            _products.Remove(tempProductDelete);

        }
         public void Update(Product product)
        {
            Product tempProductUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            //????tempProductUpdate = product;????---> böyle yapsaydık acaba olur muydu?
            tempProductUpdate.ProductName = product.ProductName;
            tempProductUpdate.CategoryID = product.CategoryID;
            tempProductUpdate.UnitPrice= product.UnitPrice;
            tempProductUpdate.UnitsInStock = product.UnitsInStock;
            
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
            //Parametre olarak gönderdiğimiz categoryId ile _product içindeki ürünlerin categoryId si eşit olanları
            //bir listeye aktardı ve return etti
            //Manule olarak bir liste oluşturup da atabilirdik ama LİNQ kullandık
        }
    }
}
