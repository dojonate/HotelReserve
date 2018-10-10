<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomSelect.aspx.cs" Inherits="HotelReserve.View.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select a Room</title>
    <link href="../Main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="hotelImageHeader">
            <asp:Image ID="hotelImage" runat="server" ImageUrl="" CssClass="hotelImage"/>
        </div>
        <asp:BulletedList ID="hotelAmenities" runat="server"></asp:BulletedList>
        <asp:Table ID="hotelRooms" runat="server">

        </asp:Table>
    </form>
</body>
</html>
