using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReserve.Model
{
    public class hotel
    {
        string hotelName;
        string hotelImageFilename;
        List<string> hotelAmenities = new List<string>();
        int hotelRoomTypes;
        Dictionary <string, int> hotelRoomPriceDict = new Dictionary<string, int>();

        public string HotelName { get => hotelName; set => hotelName = value; }
        public string HotelImageFilename { get => hotelImageFilename; set => hotelImageFilename = value; }

        public List<string> HotelAmenities { get => hotelAmenities; set => hotelAmenities = value; }
        public int HotelRoomTypes { get => hotelRoomTypes; set => hotelRoomTypes = value; }
        public Dictionary<string, int> HotelRoomPriceDict { get => hotelRoomPriceDict; set => hotelRoomPriceDict = value; }

        public static List<hotel> getHotels()
        {
            var hotels = (List<hotel>)HttpContext.Current.Session["Hotels"];
            if (hotels == null)
            {
                HttpContext.Current.Session.Add("Hotels", new List<hotel>());
                System.Diagnostics.Debug.WriteLine("New hotel created");
                hotels = (List<hotel>)HttpContext.Current.Session["Hotels"];
            } else
            {
                System.Diagnostics.Debug.WriteLine("Old Hotel Loaded");
            }
            return hotels;
        }
    }
}