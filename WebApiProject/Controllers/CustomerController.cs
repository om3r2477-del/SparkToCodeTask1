using Microsoft.AspNetCore.Mvc;
using WebApiProject;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    [ApiController]
    [Route("Customer")]
    public class CustomerController : ControllerBase
    {
        private ProjectContext context;

        public CustomerController(ProjectContext _context)
        {
            context = _context;
        }

        // Request URL => http://localhost:5071/Customer/AddCustomer
        // Request Method => POST
        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(Customer c)
        {
            context.Customers.Add(c);
            context.SaveChanges();

            return Ok(c.CustomerId);
        }

        // Request URL => http://localhost:5071/Customer/RemoveCustomer?id=1
        // Request Method => DELETE
        [HttpDelete("RemoveCustomer")]
        public IActionResult RemoveCustomer(int id)
        {
            Customer c = context.Customers.FirstOrDefault(c => c.CustomerId == id);

            if (c == null)
            {
                return NotFound("Customer not found");
            }

            context.Customers.Remove(c);
            context.SaveChanges();

            return Ok("Removed successfully");
        }

        // Request URL => http://localhost:5071/Customer/UpdateCustomerName?id=1&newName=Ahmed
        // Request Method => PATCH
        [HttpPatch("UpdateCustomerName")]
        public IActionResult UpdateCustomerName(int id, string newName)
        {
            Customer c = context.Customers.FirstOrDefault(c => c.CustomerId == id);

            if (c == null)
            {
                return NotFound("Customer not found");
            }

            c.CustomerName = newName;

            context.SaveChanges();

            return Ok();
        }

        // Request URL => http://localhost:5071/Customer/UpdateCustomerEmail?id=1&newEmail=test@test.com
        // Request Method => PATCH
        [HttpPatch("UpdateCustomerEmail")]
        public IActionResult UpdateCustomerEmail(int id, string newEmail)
        {
            Customer c = context.Customers.FirstOrDefault(c => c.CustomerId == id);

            if (c == null)
            {
                return NotFound("Customer not found");
            }

            c.CustomerEmail = newEmail;

            context.SaveChanges();

            return Ok();
        }

        // Request URL => http://localhost:5071/Customer/UpdateCustomer?id=1
        // Request Method => PUT
        [HttpPut("UpdateCustomer")]
        public IActionResult UpdateCustomer(int id, Customer newCustomer)
        {
            Customer c = context.Customers.FirstOrDefault(c => c.CustomerId == id);

            if (c == null)
            {
                return NotFound("Customer not found");
            }

            c.CustomerName = newCustomer.CustomerName;
            c.CustomerEmail = newCustomer.CustomerEmail;

            context.SaveChanges();

            return Ok();
        }

        // Request URL => http://localhost:5071/Customer/GetCustomer?id=1
        // Request Method => GET
        [HttpGet("GetCustomer")]
        public IActionResult GetCustomer(int id)
        {
            Customer c = context.Customers.FirstOrDefault(c => c.CustomerId == id);

            if (c == null)
            {
                return NotFound("Customer not found");
            }

            return Ok(c);
        }

        // Request URL => http://localhost:5071/Customer/GetALLCustomers
        // Request Method => GET
        [HttpGet("GetALLCustomers")]
        public IActionResult GetALLCustomers()
        {
            List<Customer> customers = context.Customers.ToList();

            return Ok(customers);
        }

        // Request URL => http://localhost:5071/Customer/GetByName?name=Ali
        // Request Method => GET
        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            List<Customer> customers = context.Customers
                .Where(c => c.CustomerName.Contains(name))
                .ToList();

            return Ok(customers);
        }
    }
}