using System.Diagnostics.Metrics;
using System.Net.Sockets;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read and display user's details
            Console.Write("please enter your name:");
            String userName = Console.ReadLine();

            Console.Write("please Enter your age:");
            int userAge = int.Parse(Console.ReadLine());

            Console.Write("please Enter your Hight:");
            double userHight = double.Parse(Console.ReadLine());
            
            bool  isStudent = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

            Console.Write("name:" + userName);
            Console.Write("Age:" + userAge);
            Console.Write("Highe:" + userHight);
            Console.Write("student:" + isStudent);
            /////////////////////////////////////////////////////////////////

            //calculate and display the area and perimeter of rectangle 

            Console.Write("Enter the length:");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width:");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);
            

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            //////////////////////////////////////////////////////////////////////////


            // Check if number is even or odd

            Console.Write("Enter a whole number: ");

            int wholenumber = int.Parse(Console.ReadLine());

            if (wholenumber % 2 == 0) 
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");





            }
            //  4 - Voting Eligibility

            Console.Write("Enter your age: ");
            int userAge2 = int.Parse(Console.ReadLine());

            Console.WriteLine("do you have valid national ID : (yes/no)");
            string idAnswer = Console.ReadLine();

            bool hasValidID = idAnswer == "yes";

            if(userAge2 >= 18 && hasValidID)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            ///////////////////////////////////////////////////////////


            //Task 5 - Grade Letter Lookup

            Console.Write("please Enter your Gread ( A, B, C, D or F ): ");
            char gerad = char.Parse(Console.ReadLine());

            switch(gerad)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good ");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;

                    


            }

            //////////////////////////////////////////////////////


            // Task 6 - Temperature Converter

            Console.WriteLine("Enter temperature in Celsius: ");
            float C = float.Parse(Console.ReadLine());

            float Fahrenheit = (C * 9 / 5) + 32;

            if(C < 10)
            { 
                Console.WriteLine("Cold");
        }
            else if(C >= 10 && C <= 30)
            {
                Console.WriteLine("Mild");
            }
            else
            {
                Console.WriteLine("Hot");
                
                Console.WriteLine("Temperature in Fahrenheit: " + Fahrenheit);

                /////////////////////////////////////////////////////////////////////////


                //Task 7 - Movie Ticket Pricing

                Console.Write("Enter your age: ");
                int userAge3 = int.Parse(Console.ReadLine());

                if(userAge3 >= 0 && userAge3 <=12)
                {
                    Console.WriteLine("Catigory : Child");
                    Console.WriteLine("Ticket Price: 2.000 OMR");

                }
                else if (userAge3 >= 13 && userAge3 <= 59)
                {
                    Console.WriteLine("Catigory : Adult");
                    Console.WriteLine("Ticket Price: 5.000 OMR");
                }
                else if(userAge3 >= 60)
                {
                    Console.WriteLine("Catigory : Seniors");
                    Console.WriteLine("Ticket Price:3.000 OMR");
                }
                else
                {
                    Console.WriteLine("Invalid age."); // if users agelower then 0 which is not possible 
                }

                ////////////////////////////////////////////////////////////////////

                //Task 8 - Restaurant Bill with Membership Discount

                Console.Write("Enter the total bill amount:");
                float totalBill = float.Parse(Console.ReadLine());

                Console.Write(" Are you a member ? (yes/no)");
                string memberAnswer = Console.ReadLine();

                bool isMember = memberAnswer == "yes";

                if(totalBill > 20 && isMember)

                {
                    float discount = totalBill * 15 / 100;
                    float finalBill = totalBill - discount;

                    Console.WriteLine("Original bill: " + totalBill + "OMR");
                    Console.WriteLine("Discount : " + discount + "OMR");
                    Console.WriteLine("final bill: " + finalBill + "OMR");
                }
                else
                {
                    Console.WriteLine("Original bill: " + totalBill + "OMR");
                    Console.WriteLine("Discount : 0 OMR");       //no disc
                    Console.WriteLine("final bill: " + totalBill + "OMR");
                }

                ////////////////////////////////////////////////////////////////////
                //

                //  task 9 Day Name Finder

                Console.Write("Enter a a day number (1-7) :");
                int daynumber = int.Parse(Console.ReadLine());

                switch(daynumber)
                {
                    case 1:
                        Console.WriteLine("Day: Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Day: Monday");
                        break;
                    case 3:
                        Console.WriteLine("Day: Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Day: Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Day: Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Day: Friday");
                        break;
                    case 7:
                        Console.WriteLine("Day: Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid day number.");
                        break;
                }
                ///////////////////////////////////////////////////////////////////////

                // task 10 - Mini Calculator

                Console.Write("Enter first Number :");
                float firstNumber = float.Parse(Console.ReadLine());

                Console.Write("Enter second number :");
                float secondNumber = float.Parse(Console.ReadLine());

               

                Console.Write(" please Enter opirator ( +, -, *, /, %):");
                char opirator = char.Parse(Console.ReadLine());

                float result;

                switch(opirator)
                {
                    case '+':
                            result = firstNumber + secondNumber;
                        Console.Write("Result" + result); 
                        break;

                    case '-':
                        result = firstNumber - secondNumber;
                        Console.Write("Result" + result);
                        break;

                    case '*':
                        result = firstNumber * secondNumber;
                        Console.Write("Result" + result);
                        break;

                    case '/':
                        if(secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                            Console.Write("Result" + result);

                        }
                        else
                        {
                            Console.WriteLine("can't divide by 0.");
                        }
                        break;

                    case '%':
                        if (secondNumber != 0)
                        {
                            result = firstNumber % secondNumber;
                            Console.Write("Result" + result);
                        }
                        else
                        {
                            Console.WriteLine("can't divide by 0.");
                        }
                        break; 

                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }
                ///////////////////////////////////////////////////////////////

                //Task 11 - Loan Eligibility System

                Console.Write(" Please Enter your age: ");
                int userAge4 = int.Parse(Console.ReadLine());

                Console.Write(" Please Enter your monthly income: ");
                float monthlyIncome = float.Parse(Console.ReadLine());

                Console.Write("do you have existing loan (yes/no):");
                string inputLoan = Console.ReadLine();

                bool hasLoan = inputLoan == "yes";

                if(userAge4 >= 21 && userAge4 <= 60 && monthlyIncome >= 400 && !hasLoan)
                {
                    Console.WriteLine("State: eligible for a loan.");
                }
                else
                {
                    Console.WriteLine("State: not eligible for a loan.");
                if(userAge4 < 21 || userAge4 > 60)
                    {
                        Console.WriteLine("Reason: Age out of range.");
                    }
                if(monthlyIncome < 400)
                    {
                        Console.WriteLine("Reason: income to low.");
                    }
                if(hasLoan)
                    {
                        Console.WriteLine("Reason: existing loan.");
                    }
            
            }

                ////////////////////////////////////////////////////////

                // Task 12 - Shipping Cost Calculator

                Console.Write("Enter region code (A,B,C):");
                char regionCode = char.Parse(Console.ReadLine());

                Console.Write("Enter Package wight in (KG): ");
                double packageWeight = double.Parse(Console.ReadLine());

                double baseCost = 0;
                double extracharge = 0;

                switch(regionCode)
                {
                    case 'A':
                        baseCost = 1.000;
                        if(packageWeight > 10)
                        {
                            extracharge = 5.000;
                        }
                        else if (packageWeight > 5)
                        {
                            extracharge = 2.000;
                }
                        else
                        {
                            extracharge = 0;
                        }
                        break;
                    case 'B':
                        baseCost = 3.000;
                        if(packageWeight > 10)
                        {
                            extracharge = 5.000;
                        }
                        else if (packageWeight > 5)
                        {
                            extracharge = 2.000;
                        }
                        else
                        {
                            extracharge = 0;
                        }
                
                break;
                    case 'C':
                        baseCost = 7.000;
                        if(packageWeight > 10)
                        {
                            extracharge = 5.000;
                        }
                        else if (packageWeight > 5)
                        {
                            extracharge = 2.000;
                        }
                        else
                        {
                            extracharge = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid region code.");
                        return;
                
            }
                Console.WriteLine("Base cost: " + baseCost + " OMR");
                Console.WriteLine("Extra charge: " + extracharge + " OMR");
                Console.WriteLine("Total shipping cost: " + (baseCost + extracharge) + " OMR");

                /////////////////////////////////////////////////////////


                //Task 13 - Triangle Type Classifier

                Console.Write("Enter the length of side A: ");
                double sideA = double.Parse(Console.ReadLine());

                Console.Write("Enter the length of side B: ");
                double sideB = double.Parse(Console.ReadLine());

                Console.Write("Enter the length of side C: ");
                double sideC = double.Parse(Console.ReadLine());

                if ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA))
                {
                    Console.WriteLine("The sides form a valid triangle.");
                    if (sideA == sideB && sideB == sideC)
                    {
                        Console.WriteLine("The triangle is equilateral.");
                    }
                    else if (sideA == sideB || sideA == sideC || sideB == sideC)
                    {
                        Console.WriteLine("The triangle is isosceles.");
                    }
                    else
                    {
                        Console.WriteLine("The triangle is scalene.");
                    }
                }
                else
                {
                    Console.WriteLine("The sides do not form a valid triangle.");
                }

                ///////////////////////////////////////////////////////////////////////

            
        }
}
}}
