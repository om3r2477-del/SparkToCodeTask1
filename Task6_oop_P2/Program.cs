
namespace HotelManagementSystem
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
                        Console.WriteLine("Total Cost: " + foundGuest.calculateTotalCost(rooms));


                        break;


                    case 4:

                        if (rooms.Count() == 0) // // Check if there are any rooms
                        {
                            Console.WriteLine("Their is no romms yat");
                            break;
                        }
                        Console.WriteLine("Total Rooms" + rooms.Count());

                        foreach (Room roomItem in rooms.OrderBy(r => r.RoomNumber).Select(r => r))
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
                    case 6:
                        int subChoice;

                        do
                        {
                            Console.Clear();

                            Console.WriteLine("1. Show all available rooms");
                            Console.WriteLine("2. Filter by room type");
                            Console.WriteLine("3. Filter by max price");
                            Console.WriteLine("4. Room price statistics");
                            Console.WriteLine("0. Back");

                            Console.Write("Enter your choice: ");
                            subChoice = Convert.ToInt32(Console.ReadLine());

                            switch (subChoice)
                            {
                                case 1:

                                    var availableRooms = rooms
                                        .Where(r => r.IsAvailable) // to  get available rooms
                                        .OrderBy(r => r.PricePerNight); //to  sort by price


                                    if (availableRooms.Count() == 0) // check if rooms is 0 no = rooms
                                    {
                                        Console.WriteLine("No rooms found for the selected criteria .");
                                        break;
                                    }


                                    Console.WriteLine("Count: " + availableRooms.Count());


                                    foreach (Room r in availableRooms) // display rooms
                                    {
                                        Console.WriteLine("Room Number: " + r.RoomNumber);
                                        Console.WriteLine("Room Type: " + r.RoomType);
                                        Console.WriteLine("Price: " + r.PricePerNight.ToString("F2"));
                                        Console.WriteLine();
                                    }

                                    break;



                                case 2:

                                    Console.Write("Enter room type: ");
                                    string type = Console.ReadLine(); // to get rooms type


                                    var typeRooms = rooms
                                        .Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase)); // this is to filter type


                                    if (typeRooms.Count() == 0)
                                    {
                                        Console.WriteLine("No rooms found for the selected criteria.");
                                        break;
                                    }


                                    Console.WriteLine("Count: " + typeRooms.Count());


                                    foreach (Room r in typeRooms) // display rooms
                                    {
                                        Console.WriteLine("Room Number: " + r.RoomNumber);
                                        Console.WriteLine("Room Type: " + r.RoomType);
                                        Console.WriteLine("Price: " + r.PricePerNight.ToString("F2"));
                                        Console.WriteLine("Available: " + r.IsAvailable);
                                        Console.WriteLine();
                                    }

                                    break;



                                case 3:

                                    Console.Write("Enter maximum price: ");
                                    double maxPrice = Convert.ToDouble(Console.ReadLine());


                                    var priceRooms = rooms
                                        .Where(r => r.IsAvailable && r.PricePerNight <= maxPrice) // filter available and price
                                        .OrderBy(r => r.PricePerNight); // sort price


                                    if (priceRooms.Count() == 0)
                                    {
                                        Console.WriteLine("No rooms found for the selected criteria.");
                                        break;
                                    }


                                    Console.WriteLine("Count: " + priceRooms.Count());


                                    foreach (Room r in priceRooms) // display rooms
                                    {
                                        Console.WriteLine("Room Number: " + r.RoomNumber);
                                        Console.WriteLine("Room Type: " + r.RoomType);
                                        Console.WriteLine("Price: " + r.PricePerNight.ToString("F2"));
                                        Console.WriteLine();
                                    }

                                    break;



                                case 4:

                                    Console.WriteLine("Total Rooms: " + rooms.Count());                           // F2 for two decimal placese

                                    Console.WriteLine("Available Rooms: " + rooms.Count(r => r.IsAvailable)); // to count avalible rooms

                                    Console.WriteLine("Average Price: " + rooms.Average(r => r.PricePerNight).ToString("F2")); // to know avrage price

                                    Console.WriteLine("Cheapest Price: " + rooms.Min(r => r.PricePerNight).ToString("F2")); // to know min price

                                    Console.WriteLine("Most Expensive Price: " + rooms.Max(r => r.PricePerNight).ToString("F2")); // to know max price

                                    break;



                                case 0:

                                    break;



                                default:

                                    Console.WriteLine("Invalid choice.");

                                    break;
                            }


                            if (subChoice != 0)
                            {
                                Console.WriteLine("Press any key...");
                                Console.ReadKey();
                            }


                        } while (subChoice != 0);


                        break;
                    //// Case 7 needs booked guests, so add guests and assign rooms using cases 1, 2, and 3 first.

                    case 7:
                        {
                            // check if there are  bookings
                            bool hasBookings = guests.Any(g => g.RoomNumber != "Not Assigned");

                            if (!hasBookings)
                            {
                                Console.WriteLine("No active bookings recorded.");
                                break;
                            }
                            // total gusts
                            Console.WriteLine("Total registered Gusts:" + guests.Count());

                            // gusets with assined rooms
                            Console.WriteLine("Gusets with bookings" + guests.Count(g => g.RoomNumber != "Not Assigned"));
                            // Total rooms
                            Console.WriteLine("Total rooms" + rooms.Count());

                            // booked rooms
                            Console.WriteLine("Booked Rooms: " + rooms.Count(r => r.IsAvailable == false));

                            // average nights of booked guests
                            Console.WriteLine("Average Nights: " +
                                guests
                                .Where(g => g.RoomNumber != "Not Assigned")
                                .Average(g => g.TotalNights)
                                .ToString("F2"));



                            var topGuests = guests
                                .Where(g => g.RoomNumber != "Not Assigned")
                                .OrderByDescending(g => g.calculateTotalCost(rooms))
                                .Take(3);


                            foreach (Guest g in topGuests)
                            {
                                Console.WriteLine("Guest Name: " + g.GuestName);
                                Console.WriteLine("Room Number: " + g.RoomNumber);
                                Console.WriteLine("Total Cost: " + g.calculateTotalCost(rooms).ToString("F2"));

                            }


                            // booked guest summaries using Select()


                            var guestSummary = guests
                                .Where(g => g.RoomNumber != "Not Assigned")
                                .Select(g => g.GuestName + " — Room " + g.RoomNumber +
                                " — " + g.TotalNights + " nights — OMR " +
                                g.calculateTotalCost(rooms).ToString("F2"));


                            foreach (string summary in guestSummary)
                            {
                                Console.WriteLine(summary);
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Enter Room Number: ");
                            int updateRoomNumber = Convert.ToInt32(Console.ReadLine()); // get room number

                            Room updateRoom = rooms.FirstOrDefault(r => r.RoomNumber == updateRoomNumber); // find room using FirstOrDefault()

                            if (updateRoom == null) // check if room exists
                            {
                                Console.WriteLine("Room not found.");
                                break;
                            }

                            Console.Write("Enter new price per night: ");
                            double newPrice = Convert.ToDouble(Console.ReadLine()); // to  get new price

                            if (newPrice <= 0) // validate price
                            {
                                Console.WriteLine("Price must be a positive number.");
                                break;
                            }
                            double oldPrice = updateRoom.PricePerNight; // to store old price

                            updateRoom.PricePerNight = newPrice;

                            // updated 
                            Console.WriteLine("Old Price: " + oldPrice.ToString("F2"));
                            Console.WriteLine("New Price: " + updateRoom.PricePerNight.ToString("F2"));

                            break;
                        }
                    case 9:
                        Console.Write("Enter guest name to search: ");
                        string searchName = Console.ReadLine(); // get name to search

                        var foundGuests = guests
                            .Where(g => g.GuestName.Contains(searchName, StringComparison.OrdinalIgnoreCase)); // search names using Where()

                        if (foundGuests.Count() == 0)
                        {
                            Console.WriteLine("No guests matched that search.");
                            break;
                        }
                        Console.WriteLine("Count: " + foundGuests.Count());
                        foreach (Guest g in foundGuests)
                        {
                            Console.WriteLine("Guest ID: " + g.GuestId);
                            Console.WriteLine("Guest Name: " + g.GuestName);
                            Console.WriteLine("Room Number: " + g.RoomNumber);
                            Console.WriteLine();
                        }

                        break;


                    case 10:
                        { 
                        Console.WriteLine("Room Type Breakdown Report");

                        string[] roomTypes = { "Single", "Double", "Suite" };

                        foreach (string type in roomTypes)
                        {
                            var roomsOfType = rooms.Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase));

                            int roomCount = roomsOfType.Count();

                            Console.WriteLine("\nRoom Type: " + type);
                            Console.WriteLine("Number of Rooms: " + roomCount);

                            if (roomCount > 0)
                            {
                                double averagePrice = roomsOfType.Average(r => r.PricePerNight);
                                Console.WriteLine("Average Price: " + averagePrice.ToString("F2"));
                            }
                            else
                            {
                                Console.WriteLine("Average Price: N/A");
                            }
                        }

                        double overallAverage = rooms.Average(r => r.PricePerNight);

                        Console.WriteLine("\nOverall Average Price: " + overallAverage.ToString("F2"));

                        break;
                }

                    case 11:
                        {
                            Console.WriteLine("Enter Guest ID to check out:");
                            string checkoutGuestId = Console.ReadLine();

                            Guest checkoutGuest = guests.FirstOrDefault(g => g.GuestId == checkoutGuestId);

                            if (checkoutGuest == null)
                            {
                                Console.WriteLine("Guest not found.");
                                break;
                            }

                            if (checkoutGuest.RoomNumber == "Not Assigned")
                            {
                                Console.WriteLine("This guest has no active booking.");
                                break;
                            }

                            Room checkoutRoom = rooms.FirstOrDefault(r => r.RoomNumber.ToString() == checkoutGuest.RoomNumber);

                            if (checkoutRoom == null)
                            {
                                Console.WriteLine("Room is not found.");
                                break;
                            }

                            // Final Bill
                            Console.WriteLine("Final Bill");
                            Console.WriteLine("Guest Name: " + checkoutGuest.GuestName);
                            Console.WriteLine("Room Number: " + checkoutRoom.RoomNumber);
                            Console.WriteLine("Room Type: " + checkoutRoom.RoomType);
                            Console.WriteLine("Check-In Date: " + checkoutGuest.CheckInDate);
                            Console.WriteLine("Total Nights: " + checkoutGuest.TotalNights);
                            Console.WriteLine("Price Per Night: " + checkoutRoom.PricePerNight);
                            Console.WriteLine("Total Cost: " + checkoutGuest.calculateTotalCost(rooms).ToString("F2"));

                            Console.Write("Confirm checkout (Y/N): ");
                            string confirm = Console.ReadLine();

                            if (confirm.Equals("Y", StringComparison.OrdinalIgnoreCase))
                            {
                                checkoutRoom.IsAvailable = false; // Changed room status to unavailable after checkout so Case 12 can identify rooms

                                guests.Remove(checkoutGuest); // that are unavailable and have no active guest booking.

                                Console.WriteLine("Guests left: " + guests.Count);
                                // Remove the guest from the guest list after checkout
                                Console.WriteLine("Checkout completed successfully.");

                                Console.WriteLine("Remaining Guests: " + guests.Count);
                                Console.WriteLine("Total Rooms: " + rooms.Count);

                                Console.WriteLine("Room Available: " +
                                    rooms.Any(r => r.RoomNumber == checkoutRoom.RoomNumber && r.IsAvailable));
                            }
                            else
                            {
                                Console.WriteLine("Checkout cancelled.");
                            }

                            break;
                        }
                    case 12:
                        {
                            var removableRooms = rooms
                                .Where(r => !r.IsAvailable &&
                                       !guests.Any(g => g.RoomNumber == r.RoomNumber.ToString()))
                                .OrderBy(r => r.RoomNumber);

                            if (!removableRooms.Any())
                            {
                                Console.WriteLine("All unavailable rooms are currently occupied. No rooms can be decommissioned.");
                                break;
                            }

                            foreach (Room r in removableRooms)
                            {
                                Console.WriteLine("Room Number: " + r.RoomNumber);
                                Console.WriteLine("Room Type: " + r.RoomType);
                                Console.WriteLine("Price: " + r.PricePerNight);
                            }

                            Console.WriteLine("Removable Rooms Count: " + removableRooms.Count());

                            Console.Write("Confirm removal (Y/N): ");
                            string confirmRemove = Console.ReadLine();

                            if (confirmRemove.Equals("Y", StringComparison.OrdinalIgnoreCase))
                            {
                                rooms.RemoveAll(r => !r.IsAvailable &&
                                            !guests.Any(g => g.RoomNumber == r.RoomNumber.ToString()));

                                Console.WriteLine("Updated total room count: " + rooms.Count);

                                var remainingRooms = rooms
                                    .Select(r => new { r.RoomNumber, r.RoomType });

                                foreach (var item in remainingRooms)
                                {
                                    Console.WriteLine("Room Number: " + item.RoomNumber);
                                    Console.WriteLine("Room Type: " + item.RoomType);
                                }
                            }

                            break;
                        }

                    case 13:
                        {
                            Console.WriteLine("Enter Guest ID:");
                            string extendGuestId = Console.ReadLine();

                            Guest extendGuest = guests.FirstOrDefault(g => g.GuestId == extendGuestId);

                            if (extendGuest == null)
                            {
                                Console.WriteLine("Guest not found.");
                                break;
                            }

                            if (extendGuest.RoomNumber == "Not Assigned")
                            {
                                Console.WriteLine("This guest has no active booking to extend.");
                                break;
                            }

                            Console.WriteLine("Enter additional nights:");
                            int additionalNights;

                            bool validInput = int.TryParse(Console.ReadLine(), out additionalNights);

                            if (!validInput || additionalNights <= 0)
                            {
                                Console.WriteLine("Additional nights must be a positive integer.");
                                break;
                            }

                            extendGuest.TotalNights += additionalNights;
                            Console.WriteLine("Updated Total Nights: " + extendGuest.TotalNights);
                            Console.WriteLine("New Total Cost: " + extendGuest.calculateTotalCost(rooms).ToString("F2"));

                            break;
                        }
                    case 14:
                        {
                            var activeBookings = guests
                                .Where(g => g.RoomNumber != "Not Assigned");

                            if (!activeBookings.Any())
                            {
                                Console.WriteLine("No active bookings recorded.");
                                break;
                            }

                            var highestRevenueBooking = activeBookings
                                .Select(g => new
                                {
                                    GuestName = g.GuestName,
                                    RoomNumber = g.RoomNumber,
                                    TotalCost = g.calculateTotalCost(rooms)
                                })
                                .OrderByDescending(g => g.TotalCost)
                                .Take(1);

                            foreach (var booking in highestRevenueBooking)
                            {
                                Console.WriteLine("Highest Revenue Booking");
                                Console.WriteLine("Guest Name: " + booking.GuestName);
                                Console.WriteLine("Room Number: " + booking.RoomNumber);
                                Console.WriteLine("Total Cost: " + booking.TotalCost.ToString("F2"));
                            }

                            break;
                        }
                    case 15:
                        {
                            int pageSize = 3;
                            Console.WriteLine("Enter page number :");
                            int pageNumber = Convert.ToInt32(Console.ReadLine());
                            // to calculate total number of pages using the number of guests
                            int totalPages = (int)Math.Ceiling((double)guests.Count() / pageSize);
                            // check if the page number is outside the available pages
                            if (pageNumber < 1 || pageNumber > totalPages)
                            {
                                Console.WriteLine("the page dose not exist ");
                                break;
                            }
                            // Use Skip() to skip guests from previous pages
                            // Use Take() to get only the guests for the selected page
                            var pageGuests = guests
       .Skip((pageNumber - 1) * pageSize)
       .Take(pageSize);

                            foreach (Guest g in pageGuests)
                            {
                                Console.WriteLine("Guest Id" + g.GuestId);
                                Console.WriteLine("Guest Name" + g.GuestName);
                                Console.WriteLine("Room Number" + g.RoomNumber);
                                Console.WriteLine("Check In Date" + g.CheckInDate);
                                Console.WriteLine("TotalNights" + g.TotalNights);
                                Console.WriteLine("...");
                            }
                            break;
                        }
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

