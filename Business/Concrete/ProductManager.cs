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
    }
}
