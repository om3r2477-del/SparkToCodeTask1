namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Countdown Timer

            Console.WriteLine("Enter the starting number:");
            int number = int.Parse(Console.ReadLine()); 

            for(int i = number; i >= 1; i--) {
            Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff !");

            ///////////////////////////////////////////////////

            //Task 2 - Sum of Numbers 1 to N ex:5   = 1+2+3+4+5 = 15

            Console.WriteLine("Enter a positive whole number:");
            int positiveNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for(int i = 1; i <= positiveNumber; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum is :" + sum);

            //////////////////////////////////////////////////////////// 

            //Task 3 - Multiplication Table

            Console.Write("Enter a number :");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + (num * i));

        }
    }
}}

