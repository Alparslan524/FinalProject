using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);//magic string
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded); //true ve ürün eklendi döndürür
            //return new SuccessResult(); true döndürür
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }



        public IDataResult<List<Product>> GetAll()
        {
            //Kodlar--Gereksinimleri sağlıyorsa listeleyecek. Mesela Ürünün fiyatı 50tl altındaysa burda listeleyecek
            if (DateTime.Now.Hour==5)//Görmek için bu değeri veridk
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);
        }
        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryID==id),Messages.ListedByCategoryID);
        }

        public IDataResult<List<Product>> GetAllUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max),Messages.ListedByUnitPrice);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetailDtos()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetailDtos(),Messages.ProductDetailListed);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductID == productId),Messages.ListedById);
        }
    }
}
