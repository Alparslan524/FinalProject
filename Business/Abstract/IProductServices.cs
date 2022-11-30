using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductServices
    {
        IDataResult<List<Product>> GetAll();// T => List<Product>
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();
        IDataResult<Product> GetById(int productId);

        IResult Add(Product product);//Veri olmadığı için sadece IResult
        IResult Delete(Product product);
        IResult Update(Product product);

    }
}
