using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }
        public void DisplayRoom()
        {
            Console.WriteLine("Room Number:" + RoomNumber);
            Console.WriteLine("Room Type:" + RoomType);
            Console.WriteLine("Price Per Night: " + PricePerNight);

            if (IsAvailable)
            {
                Console.WriteLine("Available");
            }
            else
            {
                Console.WriteLine("it is Booked");
            }
            }
        }
    }
