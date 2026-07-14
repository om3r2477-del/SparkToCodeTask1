using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_oop_P2
{
    internal class Guest
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(int guestId, string guestName, int roomNumber, DateTime checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = roomNumber;
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        public void DisplayGuest()
        {
            Console.WriteLine("Guest Id:" + GuestId);
            Console.WriteLine("Guest Name:" + GuestName);
            Console.WriteLine("Room Number:" + RoomNumber);
            Console.WriteLine("Check In Date" + CheckInDate.ToShortDateString());
            Console.WriteLine("Total Nights:" + TotalNights);
        }

        public double CalculateTotalCost(List <Room> rooms) // Calculates based on room price and number of nights
        {
            foreach (Room room in rooms) //  Go through each room in the rooms list
            {
                if(room.RoomNumber == RoomNumber)
                {
                    return room.PricePerNight * TotalNights; // calculte cost Room price per night × number of nights stayed
                }
            }
            return 0; // if no matching rooms is found
        }
    }
}
