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

            // task 2 
            Console.WriteLine("Enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int result = Square(number);
            Console.WriteLine("the Square is:" + result);
            // task 3 

            Console.WriteLine("Enter  temperature in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahreniate = celsiusToFahreniate(celsius);

            Console.WriteLine("Temp in fahreniate:" + fahreniate);

            //Task 4
            displayMnue();

            //Task 5
            Console.WriteLine("Entar a number :");
            int num = Convert.ToInt32(Console.ReadLine());

            bool res = isEven(num);

            if(res)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            //task 6

            Console.WriteLine("Enter the length:");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width:");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(length, width);
            double parameter = CalculatePerimeter(length, width);

            Console.WriteLine("Area" + area);
            Console.WriteLine("Parameter" + parameter);

            //task 7

            Console.WriteLine("Enter score :");
            int score = Convert.ToInt32(Console.ReadLine());

            string greade = GetGradeLetter(score);
            Console.WriteLine("greade :" + greade);
        }

        

        public static void printWelcome(string name)
        {
            Console.WriteLine("Welcome : " + name);
        }

        ////////////////////////////////////////////////////////////////////////////////////

        //Task 2 - Square Number Function
        public static int Square(int number)
        {
            return number * number;
        }

        /////////////////////////////////////////////////////////////////////////// 

        //Task 3 - Celsius to Fahrenheit Function
        public static double celsiusToFahreniate(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        //////////////////////////////////////////////////////////////////////////

        //Task 4 - Fixed Menu Display Function

        public static void displayMnue()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        //////////////////////////////////////////////////////////////////////////////////////

        //Task 5 - Even or Odd Function
        public static bool isEven(int num)
        {
            return num % 2 == 0;
        }
        /////////////////////////////////////////////////////////////////////////////////////

        //Task 6 - Rectangle Area & Perimeter Functions

        public static double CalculateArea(double length,double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter(double length,double width)
        {
            return 2 * length * width;
        }

        //////////////////////////////////////////////////////////////////

        //Task 7 - Grade Letter Function

        public static string GetGradeLetter(double score)
        {
            if(score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70) { 
            return "C";
            }
            else if(score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
}
}

