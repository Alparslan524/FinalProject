﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    //Çıplak class kalmasın
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string  CategoryName { get; set; }

    }
}