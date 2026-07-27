using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceSystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        // Category 1 : M Product (has)
        [ForeignKey("category")]
        public int CategoryId { get; set; }

        public Category category { get; set; }

        // Product M : N Order (contains)
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
