using EFCoreProject2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject2
{
    public class ProjectContext : DbContext //oop inhertance
    {
        //1- register models
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }

        public DbSet<Project> projects { get; set; }
        public DbSet<Dependent> dependents { get; set; }

        public DbSet<DeptLocation> DeptLocations { get; set; }

       public DbSet<empProj> empProjs { get; set; }


        //2- connect to database
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=DESKTOP-QENHPGP\\SQLEXPRESS;Database=CompanyDB2;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}