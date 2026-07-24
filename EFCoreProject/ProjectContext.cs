using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext //oop inhertance 
    {
        // 1- register models
       public DbSet<BankAccount> bankAccounts { get; set; }


     

        //2- connect to database

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=DESKTOP-QENHPGP\\SQLEXPRESS;Database=BankDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
