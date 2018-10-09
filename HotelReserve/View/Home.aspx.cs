using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelReserve.Model;

namespace HotelReserve
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<hotel> hotels;
        customer Customer;
        ListItemCollection rooms = new ListItemCollection();

        List<string> hotelNames = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page Loading...");
            hotels = hotel.getHotels();
            Customer = customer.getCustomer();

            if (!IsPostBack)
            {
                initializeHotel();
                foreach (hotel building in hotels)
                {
                    hotelNames.Add(building.HotelName);
                }
                hotelSelectDdl.DataSource = hotelNames.ToArray();
                hotelSelectDdl.DataBind();
            }
            hotel selectedHotel = new hotel();
            foreach (hotel possibleHotel in hotels)
            {
                System.Diagnostics.Debug.WriteLine("Hotel: " + possibleHotel.HotelName + "\n Selected hotel: " + hotelSelectDdl.SelectedValue);
                if (possibleHotel.HotelName == hotelSelectDdl.SelectedValue)
                {
                    selectedHotel = possibleHotel;

                    System.Diagnostics.Debug.WriteLine("found hotel");
                    break;
                }
            }

            Customer.Hotel = selectedHotel;

            roomOptionsDdl.Items.Clear();
            for (int i = 1; i < 10; i++)
            {
                if (i%3 == 1)
                {
                    roomOptionsDdl.Items.Add(new ListItem(((int)(i/3)+1).ToString()+" rooms, "+i.ToString()+" adults", ((int)(i/3)+1).ToString()));
                } else if (i%3 == 2)
                {
                    roomOptionsDdl.Items.Add(new ListItem(((int)(i/3)+1).ToString()+" rooms, "+i.ToString()+" adults",((int)(i/3)+1).ToString()));
                } else // if (i%3 == 0)
                {
                    roomOptionsDdl.Items.Add(new ListItem(((int)(i / 3)).ToString() + " rooms, " + i.ToString() + " adults", ((int)(i / 3)).ToString()));
                }
            }

        }

        private bool initializeHotel()
        {
            if (hotels != new List<hotel>())
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\littl\source\repos\HotelReserve\HotelReserve\App_Data\input.txt");
                bool newHotel = true;
                bool isHotelFileName = false;
                bool isHotelAmenitiesList = false;
                bool isNumOfHotelRoomTypes = false;
                bool isHotelRoomType = false;
                int.TryParse(lines[0], out int lineInt);
                int numOfHotels = lineInt;
                int remainingNumOfHotelRooms = 0;
                int hotelNum = -1;
                for (int i = 1; i < lines.Length; i++)
                {
                    if (newHotel)
                    {
                        hotelNum++;
                        hotels.Add(new hotel());
                        newHotel = false;
                        hotels[hotelNum].HotelName = lines[i];
                        isHotelFileName = true;
                        continue;
                    } else if (isHotelFileName)
                    {
                        isHotelFileName = false;
                        hotels[hotelNum].HotelImageFilename = lines[i];
                        isHotelAmenitiesList = true;
                        continue;
                    } else if (isHotelAmenitiesList) // if the line is a list of items
                    {
                        var elements = lines[i].Split(','); // split the list
                        foreach (string element in elements)
                        {
                            hotels[hotelNum].HotelAmenities.Add(element);
                        }
                        isHotelAmenitiesList = false;
                        isNumOfHotelRoomTypes = true;
                        continue;
                    } else if (isNumOfHotelRoomTypes)
                    {
                        isNumOfHotelRoomTypes = false;
                        hotels[hotelNum].HotelRoomTypes = int.Parse(lines[i]);
                        remainingNumOfHotelRooms = hotels[hotelNum].HotelRoomTypes;
                        isHotelRoomType = true;
                        continue;
                    } else if (isHotelRoomType)
                    {
                        remainingNumOfHotelRooms--;
                        string[] elements = lines[i].Split(','); // split the list
                        hotels[hotelNum].HotelRoomPriceDict.Add(elements[0], int.Parse(elements[1]));
                        if (remainingNumOfHotelRooms == 0)
                        {
                            newHotel = true;
                            isHotelRoomType = false;
                        }
                        //continue;
                    }
                }
            }
            return true;
        }

        protected void hotelSelectDdl_SelectedIndexChanged(object sender, EventArgs e)
        { /*
            hotel selectedHotel = new hotel();
            foreach (hotel possibility in hotels)
            {
                System.Diagnostics.Debug.WriteLine("Hotel: " + possibility.HotelName + "\n Selected hotel: " + hotelSelectDdl.SelectedValue);
                if (possibility.HotelName == hotelSelectDdl.SelectedValue)
                {
                    selectedHotel = possibility;

                    System.Diagnostics.Debug.WriteLine("found hotel ");
                    break;
                }

            }
            Customer.Hotel = selectedHotel;
            roomOptionsDdl.Items.Clear();
            foreach (KeyValuePair<string, int> pairing in Customer.Hotel.HotelRoomPriceDict)
            {
                roomOptionsDdl.Items.Add(new ListItem(pairing.Key, pairing.Value.ToString()));
            } */
        }

        protected void roomOptionsDdl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void findHotelLbl_Click(object sender, EventArgs e)
        {
            if (Customer.Hotel == null)
            {
                hotel selectedHotel = new hotel();
                foreach (hotel possibleHotel in hotels)
                {
                    System.Diagnostics.Debug.WriteLine("Hotel: " + possibleHotel.HotelName + "\n Selected hotel: " + hotelSelectDdl.SelectedValue);
                    if (possibleHotel.HotelName == hotelSelectDdl.SelectedValue)
                    {
                        selectedHotel = possibleHotel;

                        System.Diagnostics.Debug.WriteLine("found hotel");
                        break;
                    }
                }

                Customer.Hotel = selectedHotel;
            }
            Customer.NumberOfRooms = int.Parse(roomOptionsDdl.SelectedValue);
        }
    }
}