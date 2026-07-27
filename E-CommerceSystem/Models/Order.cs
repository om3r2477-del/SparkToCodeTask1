using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        // User 1 : M Order (places)
        [ForeignKey("user")]
        public int UserId { get; set; }

        public User user { get; set; }

        // Order 1 : 1 Review (has)
        public Review Review { get; set; }

        // Order M : N Product (contains)
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
