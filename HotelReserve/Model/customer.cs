using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReserve.Model
{
    public class customer
    {
        hotel hotel;
        int numberOfRooms;
        KeyValuePair<string, int> selectedRoom = new KeyValuePair<string, int>();
        DateTime checkIn;
        DateTime checkOut;

        public hotel Hotel { get => hotel; set => hotel = value; }
        public KeyValuePair<string, int> SelectedRoom { get => selectedRoom; set => selectedRoom = value; }
        public int NumberOfRooms { get => numberOfRooms; set => numberOfRooms = value; }
        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }

        public static customer getCustomer()
        {
            var customerSelection = (customer)HttpContext.Current.Session["customer"];
            if (customerSelection == null)
            {
                HttpContext.Current.Session.Add("customer", new customer());
                customerSelection = (customer)HttpContext.Current.Session["customer"];
            }
            return customerSelection;
        }
    }
}