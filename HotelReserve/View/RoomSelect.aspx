<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomSelect.aspx.cs" Inherits="HotelReserve.View.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select a Room</title>
    <link href="../Main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="roomSelect" runat="server">
        <div id="hotelImage" class="hotelImage">
            <asp:Image ID="hotelImage" runat="server" ImageUrl="" CssClass="hotelImage"/>
        </div>
        <div class="amenitiesList">
            <asp:BulletedList ID="hotelAmenities" runat="server"></asp:BulletedList>
        </div>
        <br />
        <asp:Table ID="hotelRooms" runat="server" CssClass="AlignTable">

        </asp:Table>
    </form>
</body>
</html>
