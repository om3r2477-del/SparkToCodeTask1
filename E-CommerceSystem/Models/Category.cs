using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceSystem.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        // Category 1 to M Product (has)
        [InverseProperty("category")]
        public List<Product> Products { get; set; }
    }
}
