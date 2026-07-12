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
            sendEmail();
        }
     public void Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                sendEmail();
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

    //
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
