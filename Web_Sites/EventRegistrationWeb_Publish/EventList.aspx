<%@ Page Title="" Language="C#" MasterPageFile="~/EventRegistration.master" AutoEventWireup="true" CodeFile="EventList.aspx.cs" Inherits="EventList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 150px;
        }
        .style7
        {
            width: 150px;
        }
    </style>
</asp:Content>
<asp:Content ID="ContentMenu" ContentPlaceHolderID="ContentPlaceHolderMenu" 
    Runat="Server">
    </asp:Content>
<asp:Content ID="ContentMain" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
    <table align="right" class="style1" style="width: 82%">
        <tr align="center">
            <td class="style6" align="center">
                <asp:Calendar ID="Calendar1" runat="server" Width="250px"></asp:Calendar>
            </td>
            <td class="style7">
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            </td>
        </tr>
    </table>
</asp:Content>

