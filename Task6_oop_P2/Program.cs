
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
                Console.WriteLine("GRAND VISTA HOTEL - MANAGEMENT SYSTEM");
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
                        Console.WriteLine("Enter Room Number:");
                        int roomNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Room Type (double , single , suite)");
                        string roomType = Console.ReadLine();

                        Console.WriteLine("Enter Price per Night:");
                        double price = Convert.ToDouble(Console.ReadLine());

                        if (roomNumber <= 0 || price <= 0)
                        {
                            Console.WriteLine("Room number and price must be positive numbers.");
                            break;
                        }


                        // Check if room number already exists using LINQ Any()
                        bool roomExists = rooms.Any(r => r.RoomNumber == roomNumber);

                        if (roomExists)
                        {
                            Console.WriteLine("Error: Room number already exists.");
                            break;
                        }


                        // Create new Room object and add it to the list
                        Room room = new Room(roomNumber, roomType, price, true);

                        rooms.Add(room);


                        // Display success message
                        Console.WriteLine("Room added successfully!");
                        Console.WriteLine("Room Number: " + roomNumber);
                        Console.WriteLine("Room Type: " + roomType);
                        Console.WriteLine("Price Per Night: " + price);
                        Console.WriteLine("Total Rooms: " + rooms.Count);

                        break;

                    case 2:
                        Console.WriteLine("Enter guest Name :");
                        string guestName = Console.ReadLine();

                        Console.WriteLine("check In Date  :");
                        string checkInDate = Console.ReadLine();

                        Console.WriteLine("Enter number of nights");
                        int totalNights = Convert.ToInt32(Console.ReadLine());

                        if (totalNights <= 0)
                        {
                            Console.WriteLine("The number of nights must be positive");
                        
                        break;
                        }                                                      // D3  means show the number with 3 digits
                        string guestId = "G" + (guests.Count() + 1).ToString("D3"); //generates a unique guest ID based on the number of guests
                        Guest guest = new Guest(guestId, guestName, "Not Assigned", checkInDate, totalNights);
                        guests.Add(guest);


                        // Display confirmation
                        Console.WriteLine("Guest registered successfully!");
                        Console.WriteLine("Guest ID: " + guestId);
                        Console.WriteLine("Guest Name: " + guestName);
                        Console.WriteLine("Check-In Date: " + checkInDate);
                        Console.WriteLine("Number of Nights: " + totalNights);

                        break;
                    case 3:
                        Console.WriteLine("Enter Guest Id:");
                        string searchGuestId = Console.ReadLine();

                        Console.WriteLine("Enter Room Number:");
                        int searchRoomNumber = Convert.ToInt32(Console.ReadLine());

                        // Find guest using LINQ FirstOrDefault()
                        Guest foundGuest = guests.FirstOrDefault(g => g.GuestId == searchGuestId);

                        if (foundGuest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }
                        Room foundRoom = rooms.FirstOrDefault(r => r.RoomNumber == searchRoomNumber);

                        if (foundRoom == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }
                        // Check if room is availabe
                        if (foundRoom.IsAvailable == false)
                        {
                            Console.WriteLine("Room is already booked.");
                            break;
                        }


                        // Update guest and room objects
                        foundGuest.RoomNumber = foundRoom.RoomNumber.ToString();
                        foundRoom.IsAvailable = false;


                        // Display booking info
                        Console.WriteLine("Booking successful!");
                        Console.WriteLine("Guest Name: " + foundGuest.GuestName);
                        Console.WriteLine("Room Number: " + foundRoom.RoomNumber);
                        Console.WriteLine("Room Type: " + foundRoom.RoomType);
                        Console.WriteLine("Price Per Night: " + foundRoom.PricePerNight);
                        Console.WriteLine("Total Nights: " + foundGuest.TotalNights);
                        Console.WriteLine("Total Cost: " + foundGuest.CalculateTotalCost(rooms));


                        break;


                    case 4:

                    if(rooms.Count() == 0) // // Check if there are any rooms
                        {
                            Console.WriteLine("Their is no romms yat"); 
                            break;
                        }
                        Console.WriteLine("Total Rooms" + rooms.Count());
                        
                    foreach(Room roomItem in rooms.OrderBy(r => r.RoomNumber).Select(r => r))
                        {
                            Console.WriteLine("RoomNumber" + roomItem.RoomNumber);
                            Console.WriteLine("Room Type: " + roomItem.RoomType);
                            Console.WriteLine("Price Per Night: " + roomItem.PricePerNight);

                            if (roomItem.IsAvailable)
                            {
                                Console.WriteLine("Status: Available");
                            }
                            else
                            {
                                Console.WriteLine("Status: Booked");
                            }

                            Console.WriteLine();
                        }

                        break;
                


                        


                    case 5:

                        if (guests.Count() == 0)
                        {
                            Console.WriteLine("there is no guests registered yet.");
                            break;
                        }
                        Console.WriteLine("Total Guests: " + guests.Count());

                        foreach (Guest guestItem in guests.OrderBy(g => g.GuestName).Select(g => g))
                        {
                            Console.WriteLine("Guest ID: " + guestItem.GuestId);
                            Console.WriteLine("Guest Name: " + guestItem.GuestName);
                            Console.WriteLine("Room Number: " + guestItem.RoomNumber);
                            Console.WriteLine("Check In Date: " + guestItem.CheckInDate);
                            Console.WriteLine("Total Nights: " + guestItem.TotalNights);
                            Console.WriteLine();
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

