using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EFCoreProject.Models
{
    public class Bank
    {
        [Key]
        public int BID { get; set; }   // Primary Key

        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
