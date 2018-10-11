<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="HotelReserve.View.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="body">
            <asp:Label ID="hotelName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="selectedRoom" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="checkIn" runat="server" Text="Check In Date: "></asp:Label>
            
            <asp:Label ID="checkOut" runat="server" Text="Check Out Date: "></asp:Label>
            <br />
            <asp:Label ID="numOfNights" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <br />
            <p id="priceSummary">Your Price Summary</p>
            <br />
            <br />
            <asp:Label ID="RoomSelected" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="subTotalPrice" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="taxes" runat="server" Text=""></asp:Label>
            <br />
            
            <br />
            <p id="totalDue">Total Due at Property: <asp:Label ID="totalPrice" runat="server" Text=""></asp:Label></p>
            <br />

        </div>
    </form>
</body>
</html>
