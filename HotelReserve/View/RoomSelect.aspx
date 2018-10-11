<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoomSelect.aspx.cs" Inherits="HotelReserve.View.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select a Room</title>
    <link href="../Main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="roomSelect" runat="server">
        <div id="hotelImageDiv" class="hotelImage">
            <asp:Image ID="hotelImage" runat="server" ImageUrl="" CssClass="hotelImage"/>
        </div>
        <div class="amenitiesList">
            <asp:BulletedList ID="hotelAmenities" runat="server"></asp:BulletedList>
        </div>
        <br />
        <asp:Table ID="hotelRooms" runat="server" CssClass="AlignTable" GridLines="Both">
            <asp:TableRow ID="Row0" runat="server">
                <asp:TableCell ID="Row0Cell0" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row0Cell1" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row0Cell2" runat="server">
                    <asp:Button ID="Button0" AccessKey="0" OnClick="Button_Click" runat="server" Text="Reserve" /> <!--PostBackUrl="~/View/Confirmation.aspx"-->
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="Row1" runat="server">
                <asp:TableCell ID="Row1Cell0" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row1Cell1" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row1Cell2" runat="server">
                    <asp:Button ID="Button1" AccessKey="1" OnClick="Button_Click" runat="server" Text="Reserve"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="Row2" runat="server">
                <asp:TableCell ID="Row2Cell0" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row2Cell1" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row2Cell2" runat="server">
                    <asp:Button ID="Button2" AccessKey="2" OnClick="Button_Click" runat="server" Text="Reserve"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="Row3" runat="server">
                <asp:TableCell ID="Row3Cell0" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row3Cell1" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row3Cell2" runat="server">
                    <asp:Button ID="Button3" AccessKey="3" OnClick="Button_Click" runat="server" Text="Reserve"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="Row4" runat="server">
                <asp:TableCell ID="Row4Cell0" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row4Cell1" runat="server"></asp:TableCell>
                <asp:TableCell ID="Row4Cell2" runat="server">
                    <asp:Button ID="Button4" AccessKey="4" OnClick="Button_Click" runat="server" Text="Reserve"/>
                </asp:TableCell>
            </asp:TableRow>

        </asp:Table>
    </form>
</body>
</html>
