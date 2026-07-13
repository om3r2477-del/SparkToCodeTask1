namespace Task6_oop_P1
{
    // banckAcoount Class
    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

    public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }
     public void Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("no enugh balance");
            }
        }
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }
        private void PrintInformation()
        {
            Console.WriteLine("name" + HolderName);
            Console.WriteLine("Balance" + Balance);
        }
    private void SendEmail()
        {
            Console.WriteLine("Email sent");
        }
    }

    //class Student

    class student
    {
        public int Grade;
        public string name;
        public string Address;

        private string email;
        int age;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine("regestrations email is sent");
        }
    }

    // class Product

    class Product
    {
        public string ProductName;
        public double Price;
        public int StockQuantity;

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("their is no enough stock");
            }
            LogTransaction();
        }
        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }
        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }
        private void PrintDetails()
        {
            Console.WriteLine("Product: " + ProductName);
            Console.WriteLine("Price;" + Price);
            Console.WriteLine("Stock:" + StockQuantity);
        }
        private void LogTransaction()
        {
            Console.WriteLine("Transaction is logged");
        }
    }
    internal class Program
    {
        static BankAccount account1;
        static BankAccount account2;

        static student student1;
        static student student2;

        static Product prod1;
        static Product prod2;
        static void Main(string[] args)
        {
            // BankAccount objects 


            BankAccount acount1 = new BankAccount();
            acount1.AccountNumber = 2002;
            acount1.HolderName = "Omar";
            acount1.Balance = 750;

            BankAccount acount2 = new BankAccount();
            acount2.AccountNumber = 2003;
            acount2.HolderName = "mutaz";
            acount2.Balance = 250;

            // // Student objects
            student student1 = new student();
            student1.name = "Ali";
            student1.Address = "Muscat";
            student1.Grade = 67;

            student student2 = new student();
            student2.name = "Ahmed";
            student2.Address = "Muscat";
            student2.Grade = 80;

            // // Product objects
            Product prod1 = new Product();
            prod1.ProductName = "mouse";
            prod1.Price = 15.5;
            prod1.StockQuantity = 200;

            Product prod2 = new Product();
            prod2.ProductName = "laptop";
            prod2.Price = 121.5;
            prod2.StockQuantity = 20;

            bool exitApp = false;
            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("20. Exit");

                Console.WriteLine("chosse an option:");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid input");
                    continue;
                }


                switch (choice)
                {
                    case 1:
                        ViewAccountDetails();
                        break;

                    case 2:
                        UpdateStudentAddress();
                        break;

                    case 3:
                        MakeDeposit();
                        break;

                    case 4:
                        MakeWithdrawal();
                        break;

                    case 5:
                        ViewProductDetails();
                        break;

                    case 6:
                        RegisterStudent();
                        break;

                    case 7:
                        CompareAccountBalances();
                        break;

                    case 8:
                        RestockProduct();
                        break;

                    case 9:
                        TransferBetweenAccounts();
                        break;

                    case 10:
                        UpdateStudentGrade();
                        break;

                    case 11:
                        StudentReportCard();
                        break;

                    case 12:
                        AccountHealthStatus();
                        break;

                    case 13:
                        BulkSaleWithRevenue();
                        break;

                    case 14:
                        ScholarshipEligibilityCheck();
                        break;

                    case 15:
                        FullBalanceTopUpFlow();
                        break;

                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }

            static void ViewAccountDetails()
            {
                Console.WriteLine(" chosse  account 1 or 2:");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)

                    account1.CheckBalance();

                else

                    account2.CheckBalance();
            }
            static void UpdateStudentAddress()
            {
                Console.WriteLine(" chosse student 1 or 2:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine(" Enter the address:");
                string address = Console.ReadLine();

                if (x == 1)
                    student1.Address = address;
                else
                    student2.Address = address;

                Console.WriteLine("Address updated.");

            }
            static void MakeDeposit()
            {
                Console.Write("Choose account (1 or 2): ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter amount: ");
                double amount = double.Parse(Console.ReadLine());

                if (x == 1)
                {
                    account1.Deposit(amount);
                    Console.WriteLine("Holder: " + account1.HolderName);
                    Console.WriteLine("Balance: " + account1.Balance);
                }
                else
                {
                    account2.Deposit(amount);
                    Console.WriteLine("Holder: " + account2.HolderName);
                    Console.WriteLine("Balance: " + account2.Balance);
                }
            }
        }
            static void MakeWithdrawal()
            {
                Console.WriteLine(" chosse account 1 or 2:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine(" Enter the amount:");
                double amount = double.Parse(Console.ReadLine());
                if (x == 1)
                {
                    account1.Withdraw(amount);
                    Console.WriteLine("Balance" + account1.Balance);
                }
                else
                {
                    account2.Withdraw(amount);
                    Console.WriteLine("Balance" + account2.Balance);

                }
            }
            static void ViewProductDetails()
            {
                Console.WriteLine(" choose product 1 or 2 ");
                int x = int.Parse(Console.ReadLine());

                if (x == 1)
                    Console.WriteLine("inventoy value" + prod1.GetInventoryValue());
                else
                    Console.WriteLine("inventoy value" + prod2.GetInventoryValue());
            }
        static void RegisterStudent()
        {
            Console.Write("Choose student 1 or 2: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            if(x == 1)
                student1.Register(email);
            else
                student2.Register(email);
            Console.WriteLine("student regustered");
        }
        static void CompareAccountBalances()
        {
            if (account1.Balance > account2.Balance)
                Console.WriteLine("Account 1 has more money.");
            else if (account2.Balance > account1.Balance)
                Console.WriteLine("Account 2 has more money.");
            else
                Console.WriteLine("Both accounts have the same balance.");
        }
        
        static void RestockProduct()
        {
            Console.Write("Choose product 1 or 2 ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product;

            if (x == 1)
                product = prod1;
            else
                product = prod2;

            product.Restock(quantity);

            if (product.StockQuantity < 10)
                Console.WriteLine("Low");
            else if (product.StockQuantity <= 49)
                Console.WriteLine("Moderate");
            else
                Console.WriteLine("Well Stocked");
        }
        static void TransferBetweenAccounts()
        {
            Console.WriteLine("scorce account 1 or 2");
            int sourceChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("destination account 1 or 2");
            int destinationChoice = int.Parse(Console.ReadLine());

            Console.Write("Amount: ");
            double amount = double.Parse(Console.ReadLine());

            BankAccount source;
            BankAccount destination;

            if (sourceChoice == 1)
                source = account1;
            else
                source = account2;

            if (destinationChoice == 1)
                destination = account1;
            else
                destination = account2;


            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);
                Console.WriteLine("Transfered.");
            }
            else
            {
                Console.WriteLine("Transfer failed.");
            }
        }
        static void UpdateStudentGrade()
        {
            Console.WriteLine("Choose student 1 or 2:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Entr new grade:");
            int grade;
            if (int.TryParse(Console.ReadLine(), out grade))
            {
                Console.WriteLine("Invalid grade.");
                return;
            }
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("grade must be bettwen 0 and 100");
                return;
            }
            if (x == 1)
                student1.Grade = grade;
            else
                student2.Grade = grade;
            Console.WriteLine("grade is updated");

        }
        static void StudentReportCard()
        {
            Console.WriteLine("Choose student 1 or 2:");
            int x = int.Parse(Console.ReadLine());
                student s;

            if (x == 1)
                s = student1;
            else
                s = student2;
            Console.WriteLine("Name: " + s.name);
            Console.WriteLine("Address: " + s.Address);
            Console.WriteLine("Grade: " + s.Grade);

            if (s.Grade >= 60)
                Console.WriteLine("Pass");
            else
                Console.WriteLine("Fail");


        }
        static void AccountHealthStatus()
        {
            Console.WriteLine("choose account 1 or 2:");
            int x = int.Parse(Console.ReadLine());

            BankAccount account;

            if (x == 1)
                account = account1;
            else
                account = account2;
            if (account.Balance < 50)
                Console.WriteLine("low balance");
            else if (account.Balance <= 1000)
                Console.WriteLine("healthy");
            else
                Console.WriteLine("premium");
        }
        static void BulkSaleWithRevenue()
        {
            Console.WriteLine("Choose product 1 or 2:");
            int x = int.Parse(Console.ReadLine());

            Product product;

            if (x == 1)
                product = prod1;
            else
                product = prod2;
            Console.WriteLine("Enter quantitiy to sell");
            int quantity = int.Parse(Console.ReadLine());

            if(product.StockQuantity <  quantity)
            {
                int needed = quantity - product.StockQuantity;
                Console.WriteLine("their is no enuogh stock. need" + needed + "more units");

            }
            else
            {
                product.Sell(quantity);
                double revenue = quantity * product.Price;
                Console.WriteLine("Revenue" + revenue);
            }
        }
    }
    }

    


