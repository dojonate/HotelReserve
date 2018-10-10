<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HotelReserve.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select a Hotel</title>
    <link rel="stylesheet" type="text/css" href="../Main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="selections">
            
            <asp:Table ID="Table1" runat="server" class="AlignTable">
                <asp:TableRow runat="server" Width="100%">
                    <asp:TableCell columnspan="2" runat="server">
                        <asp:Label ID="destinationLbl" runat="server" Text="Destination" class ="leftLabel"></asp:Label>
                        <br />
                        <asp:DropDownList ID="hotelSelectDdl" runat="server" AutoPostBack="true" 
                                          VerticalAlign="Top" Height="40px"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" Width="100%">
                    <asp:TableCell runat="server" Width="50%">
                        <asp:Label ID="checkInLbl" runat="server" Text="Check In" class ="leftLabel"></asp:Label>
                        <br />
                        <asp:TextBox ID="checkInDate" runat="server" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell runat="server" Width="50%">
                        <asp:Label ID="checkOutLbl" runat="server" Text="Check Out" class="rightLabel"></asp:Label>
                        <br />
                        <asp:TextBox ID="checkOutDate" runat="server" TextMode="Date"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow columnspan="2" runat="server" Width="100%">
                    <asp:TableCell runat="server">
                        <asp:Label ID="guestsLbl" runat="server" Text="Guests" class ="leftLabel"></asp:Label>
                        <br />
                        <asp:DropDownList ID="roomOptionsDdl" runat="server" Height="40px" OnSelectedIndexChanged="roomOptionsDdl_SelectedIndexChanged"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow columnspan="2" runat="server" Width="100%">
                    <asp:TableCell runat="server">
                        <asp:Button ID="findHotelLbl" runat="server" Text="Find a Hotel" BorderColor="Red" BackColor="#FF3300" OnClick="findHotelLbl_Click" PostBackUrl="~/View/RoomSelect.aspx" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <br />
             
        </div>
    </form>
</body>
</html>
