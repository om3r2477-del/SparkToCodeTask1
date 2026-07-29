using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApiProject.Models;

namespace WebAPIProject.Models
{
    public class Brand
    {
        [Key]
        [JsonIgnore]
        public int BrandId { get; set; }

        [Required]
        public string BrandName { get; set; }

        [Required]
        public string Country { get; set; }

        [JsonIgnore]
        public List<Product>? Products { get; set; }
    }
}