using OnlineShopping.DAL;
using OnlineShopping.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineShoppingApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IGenericRepository<Product> productRepository;

        public ProductController(IGenericRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        [Route("products")]
        public List<Product> GetProducts()
        {
            return productRepository.GetAll().ToList();
        }

        [HttpPost]
        [Route("products/add")]
        public IHttpActionResult CreateProduct(Product product)
        {
            product.CreatedOn = DateTime.Today;
            productRepository.Insert(product);
            return Ok();
        }

        [HttpDelete]
        [Route("products/delete/{id}")]
        public IHttpActionResult Delete(long id)
        {
            productRepository.Delete(id);
            return Ok();
        }
    }
}
