<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="HotelProject1.views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <style type="text/css">
        .rightAlign {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Check_Information" Text="Insertar Habitación" />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        </div>
        <div class="container-fluid">
            <div class="row">
                <asp:Button ID="Button2" runat="server" Text="Reservar" OnClick="Reserve_Room" />
                <div class="col-sm-3">
                    <asp:TextBox ID="Check_In" runat="server"></asp:TextBox>
                    <asp:Calendar ID="Check_In_Date" runat="server" OnSelectionChanged="Check_In_Date_SelectionChanged" Visible ="false" Height="200px" Width="220px" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" ShowGridLines="True">
                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                        <OtherMonthDayStyle ForeColor="#CC9966" />
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                        <SelectorStyle BackColor="#FFCC66" />
                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    </asp:Calendar>
                </div>
                <div class="col-sm-3">
                    <asp:TextBox ID="Check_Out" runat="server"></asp:TextBox>
                    <asp:Calendar ID="Check_Out_Date" runat="server" Visible="false" Height="200px" Width="220px" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" ShowGridLines="True" OnSelectionChanged="Check_Out_Date_SelectionChanged">
                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                        <OtherMonthDayStyle ForeColor="#CC9966" />
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                        <SelectorStyle BackColor="#FFCC66" />
                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    </asp:Calendar>
                </div>
                <div class="col-sm-3">
                    <asp:DropDownList ID="Type_Room" runat="server">
                        <asp:ListItem>Tipo de habitación</asp:ListItem>
                        <asp:ListItem>Doble</asp:ListItem>
                        <asp:ListItem>Simple</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:TextBox ID="Name" runat="server" Text="First Name" ForeColor="#FFCCFF" CssClass="rightAlign"></asp:TextBox>
                <asp:TextBox ID="Last_Name" runat="server" Text="Last Name" ForeColor="#FFCCFF" CssClass="rightAlign"></asp:TextBox>
            </div>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="No hay habitaciones en las fechas ingresadas" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
