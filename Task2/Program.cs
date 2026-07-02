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

        }
    }
    }

