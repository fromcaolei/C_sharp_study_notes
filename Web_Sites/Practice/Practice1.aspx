<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Practice1.aspx.cs" Inherits="Practice1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
    </p>
    <p>
        <asp:ImageButton ID="ImageButton1" runat="server" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
    </p>
    <p>
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
        </asp:ListBox>
    </p>
    <p>
        <asp:CheckBox ID="CheckBox1" runat="server" />
    </p>
    <p>
        <asp:RadioButton ID="RadioButton1" runat="server" />
    </p>
    <p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:TreeView ID="TreeView1" runat="server">
        </asp:TreeView>
    </p>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
