using EFCoreProject.Models;

namespace EFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            //add data on table Bankaccount

            //BankAccount b1 = new BankAccount();

            //b1.AccountNumber = 123456789;
            //b1.AccountType = "Savings";
            //b1.Balances = 2500.00m;
            //b1.Currency = "OMR";
            //b1.OpenDate = new DateTime(2025, 1, 10);
            //b1.Status = "Active";
            //b1.BankID = 1;

            //context.bankAccounts.Add(b1);
            //context.SaveChanges();

            //BankAccount b1 = new BankAccount();

            //Console.Write("Enter Account Number: ");
            //b1.AccountNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter Account Type: ");
            //b1.AccountType = Console.ReadLine();

            //Console.Write("Enter Balance: ");
            //b1.Balances = decimal.Parse(Console.ReadLine());

            //Console.Write("Enter Currency: ");
            //b1.Currency = Console.ReadLine();

            //Console.Write("Enter Open Date (yyyy-MM-dd): ");
            //b1.OpenDate = DateTime.Parse(Console.ReadLine());

            //Console.Write("Enter Status: ");
            //b1.Status = Console.ReadLine();

            

            //context.bankAccounts.Add(b1);
            //context.SaveChanges();


            //delete 
            Console.WriteLine("Enter ID to delete:");
            int id = int.Parse(Console.ReadLine());

            BankAccount bankAccount = context.bankAccounts.FirstOrDefault(b => b.ID == id);
            if (bankAccount == null) {
                Console.WriteLine("Bank Account not found");
            }
            else
            {
                context.bankAccounts.Remove(bankAccount);
                context.SaveChanges();
                Console.WriteLine("Bank Account removed");

            }
        }
    }
}
