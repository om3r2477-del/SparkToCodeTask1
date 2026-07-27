using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceSystem.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        // Order 1 : 1 Review (has)
        [ForeignKey("order")]
        public int OrderId { get; set; }

        public Order order { get; set; }
    }
}
