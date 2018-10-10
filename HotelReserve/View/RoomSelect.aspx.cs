using HotelReserve.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelReserve.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        customer Customer;
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer = customer.getCustomer();
            if (!IsPostBack)
            {
                hotelImage.ImageUrl = @"~\Images\" + Customer.Hotel.HotelImageFilename;
                hotelAmenities.DataSource = Customer.Hotel.HotelAmenities;
                hotelAmenities.DataBind();
                foreach (KeyValuePair<string,int> room in Customer.Hotel.HotelRoomPriceDict)
                {
                    TableRow temp = new TableRow();
                    TableCell description = new TableCell();
                    TableCell price = new TableCell();
                    TableCell bookRoom = new TableCell();
                    Button button = new Button();
                    description.Text = room.Key;
                    price.Text = room.Value.ToString();
                    button.Text = "Reserve";
                    button.BackColor = System.Drawing.Color.Azure;
                    bookRoom.Controls.Add(button);
                    TableCell[] tempCells = { description, price, bookRoom };
                    temp.Cells.AddRange(tempCells);
                    hotelRooms.Rows.Add(temp);
                }
                
            }
        }
    }
}