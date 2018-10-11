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

        override protected void OnInit(EventArgs e)
        {
            Customer = customer.getCustomer();

            createButtons();

            //REQUIRED by ASP.NET
            base.OnInit(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (ViewState["buttons"] != null)
            {
                createButtons();
            }
            if (!IsPostBack)
            {
                hotelImage.ImageUrl = @"~\Images\" + Customer.Hotel.HotelImageFilename;
                hotelImage.CssClass = "hotelImage";
                hotelAmenities.DataSource = Customer.Hotel.HotelAmenities;
                hotelAmenities.DataBind();
                
            }
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Customer.SelectedRoom = Customer.Hotel.HotelRoomPriceDict.ElementAt(int.Parse(button.AccessKey));
            System.Diagnostics.Debug.WriteLine("Button Clicked!");
            Response.Redirect("Confirmation.aspx");
        }


        private void createButtons()
        {
            for (int i = 0; i < Customer.Hotel.HotelRoomPriceDict.Count; i++)
            {
                KeyValuePair<string, int> room = Customer.Hotel.HotelRoomPriceDict.ElementAt(i);
                TableRow temp = new TableRow();
                TableCell description = hotelRooms.Rows[i].Cells[0];
                TableCell price = hotelRooms.Rows[i].Cells[1];
                description.Text = room.Key;
                price.Text = room.Value.ToString();
                
            }
            if (Customer.Hotel.HotelRoomPriceDict.Count < 5)
            {

                for (int i = Customer.Hotel.HotelRoomPriceDict.Count; i < 5; i++)
                {
                    hotelRooms.Rows.RemoveAt(Customer.Hotel.HotelRoomPriceDict.Count);
                    System.Diagnostics.Debug.WriteLine("Removed row " + i.ToString() + "!");
                }
            }
        }
        
    }
}