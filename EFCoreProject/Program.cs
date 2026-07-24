using EFCoreProject.Models;

namespace EFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            //add data on tanle Bankaccount

            BankAccount b1 = new BankAccount();
            
            b1.AccountNumber = 123456789;
            b1.AccountType = "Savings";
            b1.Balances = 2500.00m;
            b1.Currency = "OMR";
            b1.OpenDate = new DateTime(2025, 1, 10);
            b1.Status = "Active";
            b1.BankID = 1;

            context.bankAccounts.Add(b1);
            context.SaveChanges();
        }
    }
}
