using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject.Models
{
    public class Bank
    {
        public int ID { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
