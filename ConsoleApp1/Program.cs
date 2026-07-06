namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Function



            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            printWelcome(name);
        }
       public static void printWelcome(string name)
        {
            Console.WriteLine("Welcome : " + name);
        }
    }
}
