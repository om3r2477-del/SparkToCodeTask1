using E_CommerceSystem;
using E_CommerceSystem.Models;
using System;
using System.Linq;

namespace ECommerceApp
{
    public class Program
    {
        // Shared DbContext - created ONCE
        static ProjectContext context = new ProjectContext();

        // Shared login state
        static int loggedInUserId = 0;


        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");

                Console.Write("Enter your choice: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }


                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: Login(); break;
                    case 3: AddCategory(); break;
                    case 4: AddProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReview(); break;
                    case 10: ViewReviewsForProduct(); break;
                    case 11: Logout(); break;

                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }


        static void RegisterUser()
        {
            Console.Write("Enter User Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();


            User user = new User()
            {
                UserName = name,
                UserEmail = email,
                UserPassword = password
            };


            context.Users.Add(user);

            context.SaveChanges();


            Console.WriteLine("User registered successfully.");
        }


        static void Login()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // to find user by email and password    
            // FirstOrDefault means find for first user
            User user = context.Users
                .FirstOrDefault(u => u.UserEmail == email && u.UserPassword == password);


            if (user != null)
            {
                loggedInUserId = user.UserId;
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Wrong Email or Password");
            }


        static void AddCategory()
        {

        }


        static void AddProduct()
        {

        }


        static void ViewAllProducts()
        {

        }


        static void PlaceOrder()
        {

        }


        static void ViewMyOrders()
        {

        }


        static void ViewOrderDetails()
        {

        }


        static void AddReview()
        {

        }


        static void ViewReviewsForProduct()
        {

        }


        static void Logout()
        {

        }
    }
}