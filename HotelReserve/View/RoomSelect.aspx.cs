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
            }
        }
    }
}