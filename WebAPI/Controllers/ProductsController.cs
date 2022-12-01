using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]//https://localhost:44367/api/products bu linke gidersek 
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Product> Get()//burası gelicek
        {
            return new List<Product>
            {
                new Product{ProductID=1 , ProductName="elma"},
                new Product{ProductID=2 , ProductName="armut"}
            };
        }
    }
}