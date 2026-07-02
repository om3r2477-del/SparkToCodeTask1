namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Task 1 - Countdown Timer

            Console.WriteLine("Enter the starting number:");
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff !");

            ///////////////////////////////////////////////////

            //Task 2 - Sum of Numbers 1 to N ex:5   = 1+2+3+4+5 = 15

            Console.WriteLine("Enter a positive whole number:");
            int positiveNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= positiveNumber; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum is :" + sum);

            //////////////////////////////////////////////////////////// 

            //Task 3 - Multiplication Table

            Console.Write("Enter a number :");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + (num * i));

                ////////////////////////////////////////

                //Task 4 - Password Retry

                string password = "Spark2026";
                string userPassword = "";

                while (userPassword != password)
                {
                    Console.Write("Enter the password :");
                    userPassword = Console.ReadLine();
                    if (userPassword != password)
                    {
                        Console.WriteLine("Incorrect password. Please try again.");
                    }
                }
                Console.WriteLine("Access granted!");
            }

            ///////////////////////////////////////////////////////////////////       

            //Task 5 - Number Guessing Game

            int secretNumber = 27; // my secret number is 27
            int gusss;
            int attempts = 0;

            do
            {
                Console.Write("Guess the secret number:");
                gusss = int.Parse(Console.ReadLine());
                attempts++;
                if (gusss > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (gusss < secretNumber)
                {
                    Console.WriteLine("Too low.");
                }
                else
                {
                    Console.WriteLine($"you gussed the secret number");
                }
            } while (gusss != secretNumber);
            Console.WriteLine($"It took you {attempts} attempts.");


            ///////////////////////////////////////////////////////////////////////

            //Task 6 - Safe Division Calculator


            try
            {
                Console.Write("Enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number:");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("resutl is :" + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }

            catch (FormatException)

            {
                Console.WriteLine(" Invalid input");
            }


            ///////////////////////////////////////////////////////////

            //Task 7 - Repeating Menu with Exit Option




            while (true)
            {
                try
                {
                    Console.WriteLine("1) Say Hello");
                    Console.WriteLine("2) Show Current Time-of-day ");
                    Console.WriteLine("3) Exit");
                    Console.Write("Enter your choice: ");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello!");
                            break;
                        case 2:
                            Console.WriteLine("Good Morning ");
                            break;
                        case 3:
                            Console.WriteLine("Exit.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number.");
                }
                /////////////////////////////////////////////////////////////

                //Task 8 - Sum of Even Numbers Only
                
                Console.WriteLine("Enter a whole pos number:");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine(sum);
                // Ex enter =6   = 2+4+6 = 12 
            }
            
                //////////////////////////////////////////////////////////////////////////////////////////
            }
        */
            // Task 9 - Validated Positive Number Input

            int n = 0;
            bool valid = false;

            do
            {
                try
                {
                    Console.WriteLine("Enter a positive whole number:");
                    n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a positive whole number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.");
                }

            } while (!valid);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

        
        }
    }
}
    








