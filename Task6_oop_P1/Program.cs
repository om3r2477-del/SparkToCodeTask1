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
        }
    }
}
