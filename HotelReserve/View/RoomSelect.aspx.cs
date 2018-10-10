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
                hotelImage.CssClass = "hotelImage";
                hotelAmenities.DataSource = Customer.Hotel.HotelAmenities;
                hotelAmenities.DataBind();
                
                for (int i = 0; i < Customer.Hotel.HotelRoomPriceDict.Count; i++)
                {
                    KeyValuePair<string, int> room = Customer.Hotel.HotelRoomPriceDict.ElementAt(i);
                    TableRow temp = new TableRow();
                    TableCell description = new TableCell();
                    TableCell price = new TableCell();
                    TableCell bookRoom = new TableCell();
                    Button button = new Button();
                    description.Text = room.Key;
                    price.Text = room.Value.ToString();
                    button.Text = "Reserve";
                    button.OnClientClick = "button_Click";
                    button.PostBackUrl = "Confirmation.aspx";
                    button.AccessKey = i.ToString();
                    button.BackColor = System.Drawing.Color.CornflowerBlue;
                    button.BorderColor = System.Drawing.Color.DodgerBlue;
                    bookRoom.Controls.Add(button);
                    TableCell[] tempCells = { description, price, bookRoom };
                    temp.Cells.AddRange(tempCells);
                    hotelRooms.Rows.Add(temp);
                }
                
            }
        }
        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Customer.SelectedRoom = Customer.Hotel.HotelRoomPriceDict.ElementAt(int.Parse(button.AccessKey));
            System.Diagnostics.Debug.WriteLine(button.AccessKey);
        }
    }
}