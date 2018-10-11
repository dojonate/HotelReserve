using HotelReserve.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelReserve.View
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            customer Customer = customer.getCustomer();
            hotelName.Text = Customer.Hotel.HotelName;
            selectedRoom.Text = Customer.SelectedRoom.Key;
            checkIn.Text += Customer.CheckIn.ToShortDateString();
            checkOut.Text += Customer.CheckOut.ToShortDateString();
            numOfNights.Text = (Customer.CheckOut - Customer.CheckIn).Days.ToString();

            subTotalPrice.Text = ((double)Customer.SelectedRoom.Value * double.Parse(numOfNights.Text)).ToString("#.00", CultureInfo.InvariantCulture);
            totalPrice.Text = (double.Parse(subTotalPrice.Text) * 1.17).ToString("#.00", CultureInfo.InvariantCulture);
        }
    }
}