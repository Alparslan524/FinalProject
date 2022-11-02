using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductServices
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)//EntityFrameWork--InMemory--ve eklenecek sistemler
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Kodlar--Gereksinimleri sağlıyorsa listeleyecek. Mesela Ürünün fiyatı 50tl altındaysa burda listeleyecek
            return _productDal.GetAll();
        }
        
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryID==id);
        }

        public List<Product> GetAllUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
