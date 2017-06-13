<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListEvents.ascx.cs" Inherits="ListEvents" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>

<table class="style1">
    <tr>
        <td align="center">
            <asp:Calendar ID="EventCalendar" runat="server"></asp:Calendar>
        </td>
    </tr>
    <tr>
        <td align="center">
            <asp:DropDownList ID="DropDownListCountries" runat="server" AutoPostBack="True">
                <asp:ListItem>中国</asp:ListItem>
                <asp:ListItem>美国</asp:ListItem>
                <asp:ListItem>日本</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
</table>

