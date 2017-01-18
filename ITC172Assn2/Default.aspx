<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" media="screen" runat="server" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>ITC172 Assn 2: Calendar</h1>
    <h3>Holidays</h3>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar" runat="server" OnSelectionChanged="Calendar_SelectionChanged"><TitleStyle Font-Bold="True" BorderStyle="Groove" BackColor="#3399FF" /><DayHeaderStyle BackColor="#66FFCC" /></asp:Calendar>
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Outset" CssClass="Search"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
        <div><asp:Label ID="Label1" runat="server"></asp:Label></div>
        <div><asp:Label ID="Label2" runat="server"></asp:Label></div>
        <div><asp:Label ID="Label3" runat="server"></asp:Label></div>
    </div>
    </form>
</body>
</html>
