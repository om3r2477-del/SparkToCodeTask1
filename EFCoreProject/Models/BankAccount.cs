using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class BankAccount
    {
        public int ID { get; set; }
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balances { get; set; }
        public string Currency { get; set; }
        public DateTime OpenDate { get; set; }
        public string Status { get; set; }
        public int BankID { get; set; }
    }
}
