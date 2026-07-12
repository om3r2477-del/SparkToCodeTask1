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
        public void CheckBalance()
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
            if(StockQuantity >= quantity)
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
