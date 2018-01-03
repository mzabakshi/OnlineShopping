using OnlineShopping.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Inserts a new product to database
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        bool InsertProduct(Product product);

        /// <summary>
        /// Updates a product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        bool UpdateProduct(Product product);

        /// <summary>
        /// Deletes a product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteProduct(long id);
        
        /// <summary>
        /// Returns a list of all products
        /// </summary>
        /// <returns></returns>
        IList<Product> GetAllProduct();

        /// <summary>
        /// Get a product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product GetProductById(long id);
    }
}
