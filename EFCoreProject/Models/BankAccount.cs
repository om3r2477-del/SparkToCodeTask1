using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace EFCoreProject.Models
{
    public class BankAccount
    {
        [Key]
        public int ID { get; set; }   // Primary Key of BankAccount

        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balances { get; set; }
        public string Currency { get; set; }
        public DateTime OpenDate { get; set; }
        public string Status { get; set; }

        public int BankID { get; set; }
    }
}