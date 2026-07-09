namespace miniProject1
{
    internal class Program
    {
        //  store customer informations 
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            // to keep the app running until user exit
            bool exitApp = false;

            while (!exitApp)
            {
                //show menu
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
                    // get user choice
                    choice = int.Parse(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of the loop and show the menu again
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
                        Console.WriteLine("Thank you for banking with Spark Bank Goodbye.");
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
        static void DepositMoney()
        {

            Console.WriteLine("...........DepositMoney........");

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();


            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found");
                return;

            }
            double amount;

            try
            {
                Console.Write("Enter deposit amount: ");
                amount = double.Parse(Console.ReadLine());

                // to make sure that amount is positive

                if (amount <= 0)
                {
                    Console.WriteLine("amount has to be Posititve");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("invalid amount");
                return;
            }
            // for updating the balance
            //increase balance 
            balances[index] += amount;


            Console.WriteLine("Deposit successful.");
            Console.WriteLine("Balance: " + balances[index]);
        }
        ////////////////////////

        //Service 3 - Withdraw Money

        static void WithdrawMoney()

        {
            Console.Write("...WithdrawMoney...: ");

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);


            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }
            double amount;

            try
            {
                Console.Write("Enter withdrawal amount: ");
                amount = double.Parse(Console.ReadLine());

                // check for withdrawal

                if (amount <= 0)
                {
                    Console.WriteLine("Amount must be positive.");
                    return;
                }
                if (amount > balances[index])
                {
                    Console.WriteLine("Balance too low");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("invalid amount");
                return;
            }
            // reomve amount from balance 
            balances[index] -= amount;


            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Balance: " + balances[index]);
        }
        //Service 4 - Show Balance
        static void ShowBalance()
        {
            Console.Write("...ShowBalance...: ");
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            //to find accounts position
            int index = accountNumbers.IndexOf(accountNumber);

            // check if account dose not exist
            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }


            Console.WriteLine("\nCustomer: " + customerNames[index]);
            Console.WriteLine("Account Number: " + accountNumbers[index]);
            Console.WriteLine("Balance: " + balances[index]);
        }
        //  Transfer Amount

        static void TransferAmount()
        {
            Console.WriteLine("///Transfer Amount..."); //send and recve money

            Console.WriteLine("send account number");
            string send = Console.ReadLine();

            Console.WriteLine("Receiv account number");
            string Receive = Console.ReadLine();

            int sendIndex = accountNumbers.IndexOf(send);
            int ReceiveIndex = accountNumbers.IndexOf(Receive);

            // check if the account number is exist or not
            if (sendIndex == -1 || ReceiveIndex == -1) // means not allowed to trnsfar
            {
                Console.WriteLine("Account dose not exist");
                return;
            }
            if (sendIndex == ReceiveIndex)
            {
                Console.WriteLine("cant transfear to same account");
                return;
            }
            double amount;

            try
            {
                Console.WriteLine("Enter transfer amount: ");
                amount = double.Parse(Console.ReadLine());

                if (amount <= 0)
                {
                    Console.WriteLine("Amount must be positive.");
                    return;
                }
                // check if enough money avalible
                if (amount > balances[sendIndex])
                {
                    Console.WriteLine("balnace is not enough");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("invalid amount");
                return;
            }
            // to update both balance 

            balances[sendIndex] -= amount;
            balances[ReceiveIndex] += amount;
            Console.WriteLine("Transfer successful.");
        }
        // serves 6 ListAllAccounts or custome servie 1
        //Service 6 - List All Accounts
       // Purpose: Show all customers with their account numbers and balances.
        static void ListAllAccounts()
        {
            Console.WriteLine("...ListAllAccounts...");

            if (accountNumbers.Count == 0)
            {
                Console.WriteLine("their is no accounts avalibe");
                return;
            }
            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine("name:" + customerNames[i]);
                Console.WriteLine("account:" + accountNumbers[i]);
                Console.WriteLine("Balance:" + balances[i]);
            }
        }
        // serves 7 or custome servie 2 ApplyInterest
        //Service 7 - Apply Interest
        //Purpose: Add 5% interest to every account balance.
        static void ApplyInterest()
        {
            Console.WriteLine("...ApplyInterest...");
            //for adding 5% inntrest
            double intrest = 5; 

            for (int i = 0; i < balances.Count; i++)
            {
                balances[i] += balances[i] * intrest / 100;

                Console.WriteLine("intrest applied");
            }
        }
    }
}
// Used List collections to store customer names, account numbers, and balances.
// Used Add(), Contains(), IndexOf(), Count, and for loops to manage account data.