using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingApi.Models
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Image { get; set; } 
    }
}