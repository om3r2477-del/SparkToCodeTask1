namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Task 1 - Absolute Difference
            
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double subtraction = num1 - num2;

            double absoluteDifference = Math.Abs(subtraction);

            Console.WriteLine("The absolute difference is : " + absoluteDifference);

            ///////////////////////////////////////////////////////////////////////////
            
            // Task 2 - Power & Root Explorer

            Console.WriteLine("Enter a number:");
            double number = Convert.ToInt32(Console.ReadLine());

            double power2 = Math.Pow(number, 2);
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine("The number raised to the power of 2 is: " + power2);
            Console.WriteLine("The square root of the number is: " + squareRoot);

            ////////////////////////////////////////////////////////////////////////////
            
            //Task 3 - Name Formatter

            Console.WriteLine("Enter your full name:");
            string fullName = Console.ReadLine();

            Console.WriteLine(" your name in upper case: " + fullName.ToUpper());
            Console.WriteLine(" your name in lower case: " + fullName.ToLower());
            Console.WriteLine("number of Characters" + fullName.Length);

            ///////////////////////////////////////////////////////////////////////////


            // Task 4 - Subscription End Date
            

            Console.WriteLine("Enter the number of days of a free trial :");
            int freeTrialDays = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime endDate = today.AddDays(freeTrialDays);
            Console.WriteLine("The freeTrialDays : " + endDate.ToString("yyyy-MM-dd")); // so here i have to use uppercase MM to show the month
            /////////////////////////////////////////////////////////////////////////////
            
            
            // Task 5 - Grade Rounding System

            Console.WriteLine("Enter your Exam Score:");
            double examScore = Convert.ToDouble(Console.ReadLine());

            double roundedScore = Math.Round(examScore, 0); // here used 0 to round it to nearest whole number

            Console.WriteLine("Rounded Score: " + roundedScore);

            if(roundedScore >= 60) { 
                Console.WriteLine("You passed the exam.");
        }
            else
            {
                Console.WriteLine("You failed the exam.");
                /////////////////////////////////////////////////////////////////
               
                
                // Task 6 - Password Strength Checker



                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();

                if(password.Length >= 8 && !password.ToLower().Contains("password")) //at least 8 characters and does not contain the word "password"
                {
                    Console.WriteLine("Your password is strong.");
                }
                else
                {
                    Console.WriteLine("Your password is weak.");
                }
            if(password.Length < 8)
                {
                    Console.WriteLine("Password should be at least 8 characters long.");
                }
            if(password.ToLower().Contains("password"))
                {
                    Console.WriteLine("Password should not contain the word 'password'.");
                }

            //////////////////////////////////////////////////////////////////////////////////

            */

            //Task 7 - Clean Name Comparator

            Console.WriteLine("Enter the first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the second name:");
            string secondName = Console.ReadLine();

            firstName = firstName.Trim().ToLower(); // i used lower to make it case-insensitive
            secondName = secondName.Trim().ToLower();      // i used Trim to remove any extra whitespace 

            if (firstName == secondName)
            {
                Console.WriteLine("Match.");
            }
            else
            {
                Console.WriteLine("no Match.");
            }
        }
    }
}

