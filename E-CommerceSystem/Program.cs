using E_CommerceSystem;
using E_CommerceSystem.Models;
using Microsoft.EntityFrameworkCore;
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
        }


        static void AddCategory()
        {
            Category category = new Category();

            Console.Write("Enter Category Name: ");
            category.CategoryName = Console.ReadLine();

            context.Categories.Add(category);
            context.SaveChanges();

            Console.WriteLine("Category Added Successfully");

        }


        static void AddProduct()
        {
            Product p = new Product();

            Console.Write("Product Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Price: ");
            p.ProductPrice = double.Parse(Console.ReadLine());


            // Show existing categories
            var categories = context.Categories.ToList();

            if (categories.Count == 0)
            {
                Console.WriteLine("No categories available. Add a category first.");
                return;
            }


            Console.WriteLine("Choose Category:");

            foreach (var c in categories)
            {
                Console.WriteLine(c.CategoryId + " - " + c.CategoryName);
            }


            Console.Write("Enter Category Id: ");
            int categoryId = int.Parse(Console.ReadLine());


            // Check category exists
            Category category = context.Categories
                .FirstOrDefault(c => c.CategoryId == categoryId);


            if (category == null)
            {
                Console.WriteLine("Category not found");
                return;
            }


            // Link product to category
            p.CategoryId = category.CategoryId;


            context.Products.Add(p);
            context.SaveChanges();


            Console.WriteLine("Product Added Successfully");
        }


        static void ViewAllProducts()
        {
            var products = context.Products
                .Include(p => p.category)
                .ToList();

            foreach (var p in products)
            {
                Console.WriteLine("Name: " + p.ProductName);
                Console.WriteLine("Price: " + p.ProductPrice);
                Console.WriteLine("Category: " + p.category.CategoryName);
            }
        }

        static void PlaceOrder()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please login first");
                return;
            }


            Order order = new Order()
            {
                UserId = loggedInUserId,
                OrderDate = DateTime.Now
            };


            context.Orders.Add(order);
            context.SaveChanges();


            while (true)
            {
                Console.Write("Product Id: ");
                int productId = int.Parse(Console.ReadLine());


                Product product = context.Products
                    .FirstOrDefault(p => p.ProductId == productId);


                if (product == null)
                {
                    Console.WriteLine("Product not found");
                    continue;
                }


                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());


                if (quantity <= 0)
                {
                    Console.WriteLine("Quantity must be greater than 0");
                    continue;
                }


                OrderProduct op = new OrderProduct()
                {
                    OrderId = order.OrderId,
                    ProductId = productId,
                    Quantity = quantity
                };


                context.OrderProducts.Add(op);


                Console.Write("Add another product? (y/n): ");
                string answer = Console.ReadLine();


                if (answer.ToLower() != "y")
                    break;
            }


            try
            {
                context.SaveChanges();
                Console.WriteLine("Order Placed Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ViewMyOrders()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please login first");
                return;
            }


            var orders = context.Orders
                .Where(o => o.UserId == loggedInUserId)
                .ToList();


            foreach (var o in orders)
            {
                Console.WriteLine("Order Id: " + o.OrderId);
                Console.WriteLine("Date: " + o.OrderDate);
            }
        }


        static void ViewOrderDetails()
        {
            Console.Write("Enter Order Id: ");
            int id = int.Parse(Console.ReadLine());


            Order order = context.Orders
                .FirstOrDefault(o => o.OrderId == id);


            if (order == null)
            {
                Console.WriteLine("Order not found");
                return;
            }


            double total = 0;


            var items = context.OrderProducts
                .Where(op => op.OrderId == id)
                .ToList();


            foreach (var item in items)
            {
                Product p = context.Products
                    .FirstOrDefault(x => x.ProductId == item.ProductId);


                Console.WriteLine("Product: " + p.ProductName);
                Console.WriteLine("Quantity: " + item.Quantity);

                total += p.ProductPrice * item.Quantity;
            }


            Console.WriteLine("Total: " + total);


            Review review = context.Reviews
                .FirstOrDefault(r => r.OrderId == id);


            if (review != null)
            {
                Console.WriteLine("Rating: " + review.Rating);
                Console.WriteLine("Comment: " + review.Comment);
            }
            else
            {
                Console.WriteLine("No Review");
            }
        }


        static void AddReview()
        {
            if (loggedInUserId == 0)
            {
                Console.WriteLine("Please login first");
                return;
            }


            Console.Write("Order Id: ");
            int orderId = int.Parse(Console.ReadLine());


            Order order = context.Orders
                .FirstOrDefault(o => o.OrderId == orderId && o.UserId == loggedInUserId);


            if (order == null)
            {
                Console.WriteLine("Order not found");
                return;
            }


            Review oldReview = context.Reviews
                .FirstOrDefault(r => r.OrderId == orderId);


            if (oldReview != null)
            {
                Console.WriteLine("Order already has review");
                return;
            }


            Review review = new Review();

            Console.Write("Rating: ");
            review.Rating = int.Parse(Console.ReadLine());

            Console.Write("Comment: ");
            review.Comment = Console.ReadLine();

            review.OrderId = orderId;


            context.Reviews.Add(review);
            context.SaveChanges();


            Console.WriteLine("Review Added");

        }


        static void ViewReviewsForProduct()
        {
            Console.Write("Product Id: ");
            int productId = int.Parse(Console.ReadLine());

            var orders = context.OrderProducts
                .Where(op => op.ProductId == productId)
                .ToList();


            foreach (var op in orders)
            {
                Review review = context.Reviews
                    .FirstOrDefault(r => r.OrderId == op.OrderId);

                if (review != null)
                {
                    Console.WriteLine("Order Id: " + op.OrderId);
                    Console.WriteLine("Rating: " + review.Rating);
                    Console.WriteLine("Comment: " + review.Comment);
                }
                else
                {
                    Console.WriteLine("order" + op.OrderId + "has no Review");
                }
            }
        }

            static void Logout()
            {
                loggedInUserId = 0;  // Reset loggedInUserId to 0 because 0 means no user is logged in
            Console.WriteLine("Logged  out successfully");
            }
        }
    }