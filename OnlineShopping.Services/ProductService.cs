using OnlineShopping.DAL;
using OnlineShopping.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> productRepository;

        public ProductService(IGenericRepository<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        /// <summary>
        /// Inserts a new product to database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool InsertProduct(Product product)
        {
            try
            {
                productRepository.Insert(product);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Updates a product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool UpdateProduct(Product product)
        {
            try
            {
                productRepository.Update(product);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes a product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteProduct(long id)
        {
            try
            {
                productRepository.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Returns a list of all products
        /// </summary>
        /// <returns></returns>
        public IList<Product> GetAllProduct()
        {
            return productRepository.GetAll().ToList();
        }

        /// <summary>
        /// Get a product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProductById(long id)
        {
            return productRepository.GetById(id);
        }
    }
}
