using Microsoft.EntityFrameworkCore;
using WebApiProject.Models;

namespace WebApiProject
{
    public class ProjectContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
