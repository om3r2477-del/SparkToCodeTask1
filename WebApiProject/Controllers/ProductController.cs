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

    }
}
