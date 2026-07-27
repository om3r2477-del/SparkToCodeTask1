using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_CommerceSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        // User 1 to M Order (place)
        [InverseProperty("user")]
        public List<Order> Orders { get; set; }
    }
}
