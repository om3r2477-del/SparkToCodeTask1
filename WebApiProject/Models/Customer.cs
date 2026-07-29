using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebAPIProject.Models
{
    public class Customer
    {
        [Key]
        [JsonIgnore]
        public int CustomerId { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerEmail { get; set; }
    }
}