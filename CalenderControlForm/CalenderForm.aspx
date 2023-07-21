<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalenderForm.aspx.cs" Inherits="CalenderControlForm.CalenderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Calender Control"></asp:Label>
            <br />
            <br />
            Select Your Date From The Below Calender..!!<br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#FF3300" BorderStyle="Dotted" FirstDayOfWeek="Sunday" NextMonthText="Next" OnSelectionChanged="Calendar1_SelectionChanged" PrevMonthText="Previous" ShowGridLines="True">
                <TodayDayStyle BackColor="White" />
            </asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Your Date" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>>
