using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceSystem.Models
{
    [PrimaryKey(nameof(OrderId), nameof(ProductId))]
    public class OrderProduct
    {
        [ForeignKey("order")]
        public int OrderId { get; set; }

        public Order order { get; set; }

        [ForeignKey("product")]
        public int ProductId { get; set; }

        public Product product { get; set; }

        public int Quantity { get; set; }
    }
}