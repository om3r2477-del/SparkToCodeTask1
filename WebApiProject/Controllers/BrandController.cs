using Microsoft.AspNetCore.Mvc;
using WebApiProject;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Brand")]
    public class BrandController : ControllerBase
    {
        private ProjectContext context;

        public BrandController(ProjectContext _context)
        {
            context = _context;
        }

        // Request URL => http://localhost:5071/Brand/AddBrand
        // Request Method => POST
        [HttpPost("AddBrand")]
        public IActionResult AddBrand(Brand b)
        {
            context.Brands.Add(b);
            context.SaveChanges();

            return Ok(b.BrandId);
        }

        // Request URL => http://localhost:5071/Brand/RemoveBrand?id=1
        // Request Method => DELETE
        [HttpDelete("RemoveBrand")]
        public IActionResult RemoveBrand(int id)
        {
            Brand b = context.Brands.FirstOrDefault(b => b.BrandId == id);

            if (b == null)
            {
                return NotFound("Brand not found");
            }

            context.Brands.Remove(b);
            context.SaveChanges();

            return Ok("Removed successfully");
        }

        // Request URL => http://localhost:5071/Brand/UpdateBrandName?id=1&newName=Apple
        // Request Method => PATCH
        [HttpPatch("UpdateBrandName")]
        public IActionResult UpdateBrandName(int id, string newName)
        {
            Brand b = context.Brands.FirstOrDefault(b => b.BrandId == id);

            if (b == null)
            {
                return NotFound("Brand not found");
            }

            b.BrandName = newName;

            context.SaveChanges();

            return Ok();
        }

        // Request URL => http://localhost:5071/Brand/UpdateCountry?id=1&newCountry=USA
        // Request Method => PATCH
        [HttpPatch("UpdateCountry")]
        public IActionResult UpdateCountry(int id, string newCountry)
        {
            Brand b = context.Brands.FirstOrDefault(b => b.BrandId == id);

            if (b == null)
            {
                return NotFound("Brand not found");
            }

            b.Country = newCountry;

            context.SaveChanges();

            return Ok();
        }

        // Request URL => http://localhost:5071/Brand/UpdateBrand?id=1
        // Request Method => PUT
        [HttpPut("UpdateBrand")]
        public IActionResult UpdateBrand(int id, Brand newBrand)
        {
            Brand b = context.Brands.FirstOrDefault(b => b.BrandId == id);

            if (b == null)
            {
                return NotFound("Brand not found");
            }

            b.BrandName = newBrand.BrandName;
            b.Country = newBrand.Country;

            context.SaveChanges();

            return Ok();
        }

        // Request URL => http://localhost:5071/Brand/GetBrand?id=1
        // Request Method => GET
        [HttpGet("GetBrand")]
        public IActionResult GetBrand(int id)
        {
            Brand b = context.Brands.FirstOrDefault(b => b.BrandId == id);

            if (b == null)
            {
                return NotFound("Brand not found");
            }

            return Ok(b);
        }

        // Request URL => http://localhost:5071/Brand/GetALLBrands
        // Request Method => GET
        [HttpGet("GetALLBrands")]
        public IActionResult GetALLBrands()
        {
            List<Brand> brands = context.Brands.ToList();

            return Ok(brands);
        }

        // Request URL => http://localhost:5071/Brand/GetByName?name=App
        // Request Method => GET
        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            List<Brand> brands = context.Brands
                .Where(b => b.BrandName.Contains(name))
                .ToList();

            return Ok(brands);
        }
    }
}