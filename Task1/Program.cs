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


        }


    }
    }
}
