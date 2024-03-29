﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity //Public olduğu için business, dataaccess, entities erişebilecek.
                         //Defaultu INTERNAL(internal olursa sadece entities içinde kullanılabilir)
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short  UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
