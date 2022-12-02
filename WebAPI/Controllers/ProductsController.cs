using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductServices _productServices;//Constructor Injection

        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet("getall")]//https://localhost:44367/api/products/getall ile çalışır. Bütün ürünleri listeler
        public IActionResult GetAll()
        {
            var result = _productServices.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("getbyid")]//https://localhost:44367/api/products/getbyid?id=5 ile çalışır. İdsi 5 olan ürünü listeler
        public IActionResult GetById(int id)
        {
            var result = _productServices.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]//https://localhost:44367/api/products/add ile çalışır. Ürünü ekler
        public IActionResult Add(Product product)
        {
            var result = _productServices.Add(product);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]//https://localhost:44367/api/products/delete ile çalışır. Ürünü siler
        public IActionResult Delete(Product product)
        {
            var result = _productServices.Delete(product);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}