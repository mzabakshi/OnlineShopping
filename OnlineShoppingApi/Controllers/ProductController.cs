using OnlineShopping.DAL;
using OnlineShopping.DAL.Models;
using OnlineShopping.Services;
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
        private readonly IProductService productService;

        public ProductController(IGenericRepository<Product> productRepository, IProductService productService)
        {
            this.productRepository = productRepository;
            this.productService = productService;
        }

        [HttpGet]
        [Route("products")]
        public List<Product> GetProducts()
        {
            return productService.GetAllProduct().ToList();
        }

        [HttpPost]
        [Route("products/add")]
        public IHttpActionResult CreateProduct(Product product)
        {
            product.CreatedOn = DateTime.Today;
            //productRepository.Insert(product);
            productService.InsertProduct(product);
            return Ok();
        }

        [HttpDelete]
        [Route("products/delete/{id}")]
        public IHttpActionResult Delete(long id)
        {
            productService.DeleteProduct(id);
            return Ok();
        }
    }
}
