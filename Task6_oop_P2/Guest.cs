using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_oop_P2
{
    internal class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(string guestId, string guestName, string roomNumber, string checkInDate, int totalNights)
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
            Console.WriteLine("Check In Date" + CheckInDate);
            Console.WriteLine("Total Nights:" + TotalNights);
        }

        public double calculateTotalCost(List <Room> rooms) // Calculates based on room price and number of nights
        {
            foreach (Room room in rooms) //  Go through each room in the rooms list
            {
                if (room.RoomNumber.ToString() == RoomNumber)
                {
                    return room.PricePerNight * TotalNights;
                }
            }
            return 0; // if no matching rooms is found
        }
    }
}
