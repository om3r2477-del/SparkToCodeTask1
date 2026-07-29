using Microsoft.AspNetCore.Mvc;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    
    {
        private ProjectContext context;

        public ProductController(ProjectContext _context)
        {
            context = _context;
        }
      //  ProductContext context = new Product();

        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product p)
        {

            context.Products.Add(p);
            context.SaveChanges();

            return Ok(p.ProductId);
        }
        [HttpDelete("RemoveProduct")]
        public IActionResult RemoveProduct(int id)
        {

            Product p = context.Products.FirstOrDefault(p => p.ProductId == id);

            if (p == null)
            {
                return NotFound("product not found");
            }
            else
            {
                context.Products.Remove(p);
                context.SaveChanges();
                return Ok("removed successfully");
            }
        }
    }
}
