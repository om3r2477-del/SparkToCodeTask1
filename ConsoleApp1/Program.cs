using System.Drawing;

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

            if (res)
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

            //task 8 

            Console.WriteLine("Enter starting number:");
            int snumber = Convert.ToInt32(Console.ReadLine());
            Countdown(snumber);

            //task 9

            int res1 = Multiply(2, 3);
            Console.WriteLine("Multiply int1,int2:" + res1);

            double res2 = Multiply(2.3, 3.4);
            Console.WriteLine("Multiply double1,double2:" + res2);

            int res3 = Multiply(2, 3, 4);
            Console.WriteLine("Multiply int1,int2,int3:" + res3);

            // task 10

            Console.WriteLine(" choose 1)shape 2) squre 3) rectangle");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter side:");
                double side = Convert.ToDouble(Console.ReadLine());

                double area2 = CalculateArea2(side);
                Console.WriteLine("area" + area2);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter length:");
                double length2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter width:");
                double width2 = Convert.ToDouble(Console.ReadLine());
                double area2 = CalculateArea2(length2, width2);
                Console.WriteLine("area" + area2);

                // task 11

                int choicee = 0;

                while (choicee != 5)
                {
                    Console.WriteLine("calculation:");
                    Console.WriteLine("1) Add:");
                    Console.WriteLine("2) subtract:");
                    Console.WriteLine("3) multiply:");
                    Console.WriteLine("4) divide:");
                    Console.WriteLine("5) exit :");
                    Console.WriteLine("Enter your choice:");

                    int coicee = Convert.ToInt32(Console.ReadLine());

                    switch (coicee)
                    {
                        case 1:
                            Console.WriteLine("Enter first number :");
                            double AddNumber1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter second number :");
                            double AddNumber2 = Convert.ToDouble(Console.ReadLine());

                            displayresult("Addititon", Add(AddNumber1, AddNumber2));

                            break;

                        case 2:
                            Console.WriteLine("Enter first number :");
                            double subNumber1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter second number :");
                            double subNumber2 = Convert.ToDouble(Console.ReadLine());

                            displayresult("subtraction", Subtract(subNumber1, subNumber2));

                            break;

                        case 3:
                            Console.WriteLine("Enter first number :");
                            double mulNumber1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter second number :");
                            double mulNumber2 = Convert.ToDouble(Console.ReadLine());

                            displayresult("multiplacation", multiplyy(mulNumber1, mulNumber2));

                            break;

                        case 4:
                            Console.WriteLine("Enter first number :");
                            double divNumber1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter second number :");
                            double divNumber2 = Convert.ToDouble(Console.ReadLine());

                            displayresult("divition", divition(divNumber1, divNumber2));

                            break;

                        case 5:
                            Console.WriteLine("Thank you ");

                            break;
                        default:
                            Console.WriteLine("invlid coice");
                            break;

                    }
                    Console.WriteLine();
                }

            }
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

        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * length * width;
        }

        //////////////////////////////////////////////////////////////////

        //Task 7 - Grade Letter Function

        public static string GetGradeLetter(double score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        ///////////////////////////////////////////////////////////////////////////

        //Task 8 - Countdown Function

        public static void Countdown(int snumber)
        {
            for (int i = snumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////

        //Task 9 - Overloaded Multiply Function

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        //Task 10 - Overloaded Area Calculator

        public static double CalculateArea2(double side)
        {
            return side * side;
        }

        public static double CalculateArea2(double length2, double width2)
        {
            return length2 * width2;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////


        // Task 11 - Function-Based Calculator

        public static double Add(double AddNumber1, double AddNumber2)
        {
            return AddNumber1 + AddNumber2;
        }

        public static double Subtract(double subNumber1, double subNumber2)
        {
            return subNumber1 - subNumber2;
        }

        public static double multiplyy(double mulNumber1, double mulNumber2)
        {
            return mulNumber1 * mulNumber2;
        }

        public static double divition(double num1, double num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }

                return num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;
            }
        }

        public static void displayresult(string operation, double result)
        {
            Console.WriteLine(" Result: ");
            Console.WriteLine("Operation: " + operation);
            Console.WriteLine("Result: " + result);
            Console.WriteLine("------------------");
        }

        //////////////////////////////////////

        //Task 12 - Student Report Card Generator
    }
}

