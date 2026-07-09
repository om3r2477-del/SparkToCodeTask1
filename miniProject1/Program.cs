namespace miniProject1
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List all amounts");
                Console.WriteLine("7. Applay intrest");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        ApplyInterest();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            }
        }
        //Add new accounts
        static void AddAccount()
        {
            Console.WriteLine("Add new account:");
            Console.WriteLine("Enter cusomer name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter cusomer account number:");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber)) // to check it their is dublicate account number
            {
                Console.WriteLine("Account already exists.");
                return;
            }


            double deposit;

            try
            {
                Console.Write("Enter initial deposit: ");
                deposit = double.Parse(Console.ReadLine());


                // Check if deposit is negative

                if (deposit < 0)
                {
                    Console.WriteLine("Deposit cant be negative.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }


            // Add data to all lists

            customerNames.Add(name);
            accountNumbers.Add(accountNumber);
            balances.Add(deposit);


            Console.WriteLine("Account created successfully.");
        }



    }
