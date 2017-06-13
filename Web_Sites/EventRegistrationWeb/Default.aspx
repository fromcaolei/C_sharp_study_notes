<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
    
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 52%;
            height: 149px;
        }
        .style2
        {
            width: 76px;
        }
        .style3
        {
            width: 182px;
        }
        .style4
        {
            width: 944px;
            height: 109px;
        }
        .style8
        {
            height: 21px;
            width: 188px;
        }
        .style12
        {
            height: 21px;
            width: 189px;
        }
        .style13
        {
            height: 22px;
            width: 188px;
        }
        .style14
        {
            height: 22px;
            width: 189px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <table align="center" class="style1" dir="ltr">
        <tr>
            <td class="style2">
                <asp:Label ID="labelEvent" runat="server" Text="Event:"></asp:Label>
            </td>
            <td class="style3">
                <asp:DropDownList ID="dropDownListEvents" runat="server" Width="179px">
                    <asp:ListItem>SQL Server 2005 and XML</asp:ListItem>
                    <asp:ListItem>Office 2003 and XML</asp:ListItem>
                    <asp:ListItem>Introduction to ASP.NET</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="labelFirstname" runat="server" Text="Firstname:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="textFirstname" runat="server" Width="175px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="textFirstname" ErrorMessage="Firstname is required." 
                    Enabled="False"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="labelLastname" runat="server" Text="Lastname:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="textLastname" runat="server" Width="175px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="textLastname" ErrorMessage="Lastname is required." 
                    Enabled="False"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="labelEmail" runat="server" Text="Email:"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="textEmail" runat="server" Width="175px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="textEmail" ErrorMessage="Email is required." 
                    Enabled="False"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="textEmail" Display="Dynamic" 
                    ErrorMessage="Enter a valid email." 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    Enabled="False"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="buttonSubmit" runat="server" Text="Submit" 
                    PostBackUrl="~/ResultPage.aspx" onclick="buttonSubmit_Click" 
                    style="height: 21px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <p>
        <asp:Label ID="labelResult" runat="server" Text="Label"></asp:Label>
    </p>
    <table class="style4">
        <tr>
            <td align="center" class="style8">
                <asp:Button ID="Button2" runat="server" 
                    PostBackUrl="~/Admin/EventsManagement.aspx" Text="用户管理界面" />
            </td>
            <td align="center" class="style8">
                <asp:Button ID="Button1" runat="server" PostBackUrl="~/EventList.aspx" 
                    Text="使用自定义主页" />
            </td>
            <td align="center" class="style8">
                <asp:Button ID="Button3" runat="server" PostBackUrl="~/UseMyControl.aspx" 
                    Text="使用用户控件" />
            </td>
            <td align="center" class="style12">
                <asp:Button ID="Button4" runat="server" PostBackUrl="~/ProfileDemo.aspx" 
                    Text="个性化配置" />
            </td>
            <td align="center" class="style12">
                <asp:Button ID="Button5" runat="server" PostBackUrl="~/WebPartDemo.aspx" 
                    Text="Web部件" />
            </td>
        </tr>
        <tr>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style14">
                &nbsp;</td>
            <td align="center" class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style14">
                &nbsp;</td>
            <td align="center" class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style14">
                &nbsp;</td>
            <td align="center" class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style13">
                &nbsp;</td>
            <td align="center" class="style14">
                &nbsp;</td>
            <td align="center" class="style14">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

