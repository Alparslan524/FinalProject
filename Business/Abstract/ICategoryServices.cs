﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryServices 
    {
        
        IDataResult<List<Category>> GetAll();// T => List<Product>
        IDataResult<Category> GetById(int categoryId);



    }
}
