using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
