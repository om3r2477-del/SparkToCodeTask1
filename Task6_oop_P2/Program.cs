namespace Task6_oop_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store all rooms
            List<Room> rooms = new List<Room>();

            // Create a list to store all guests
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room(100, "double", 20, true));
            rooms.Add(new Room(200, "single", 30, true));
            rooms.Add(new Room(300, "single", 40, true));
            rooms.Add(new Room(400, "double", 50, true));
            rooms.Add(new Room(500, "Suite", 60, true));
            rooms.Add(new Room(600, "double", 70, true));

            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine(".............................................");
                Console.WriteLine("GRAND VISTA HOTEL - MANAGEMENT SYSTEM\"");
                Console.WriteLine(".............................................");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Gusts");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");

                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)

                {
                    case 1:
                        Console.WriteLine("Add New Room");
                        break;
                    case 2:
                        Console.WriteLine("Register New Guest");
                        break;


                    case 3:
                        Console.WriteLine("Book Room");
                        break;


                    case 4:

                        // Display all rooms
                        foreach (Room room in rooms)
                        {
                            room.DisplayRoom();
                        }

                        break;


                    case 5:

                        // Display all guests
                        if (guests.Count == 0)
                        {
                            Console.WriteLine("No guests found.");
                        }
                        else
                        {
                            foreach (Guest guest in guests)
                            {
                                guest.DisplayGuest();
                            }
                        }

                        break;


                    case 0:

                        Console.WriteLine("Exit program");
                        break;


                    default:

                        Console.WriteLine("Invalid choice");
                        break;
                }


                if (choice != 0)
                {
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                }


            } while (choice != 0);

        }
            }
    }
}
