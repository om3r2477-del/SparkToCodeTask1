using Microsoft.EntityFrameworkCore;
using WebApiProject.Models;
using WebAPIProject.Models;

namespace WebApiProject
{
    public class ProjectContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }
    }
}
