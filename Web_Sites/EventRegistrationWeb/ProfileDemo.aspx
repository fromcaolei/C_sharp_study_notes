<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileDemo.aspx.cs" Inherits="ProfileDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:Label ID="LabelLastVisit" runat="server" Text="LabelLastVisit"></asp:Label>
        <br />
        <asp:Label ID="LabelVisitCount" runat="server" Text="LabelVisitCount"></asp:Label>
        <br />
        <asp:Label ID="LabelSelectedCountry" runat="server" Text="LabelSelectedCountry"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>中国</asp:ListItem>
            <asp:ListItem>美国</asp:ListItem>
            <asp:ListItem>日本</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
