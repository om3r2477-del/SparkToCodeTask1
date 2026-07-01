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
            }


        }
        }
    }
}
