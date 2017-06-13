<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EventsManagement.aspx.cs" Inherits="Admin_EventsManagement" %>
<!--%@ PreviousPageType VirtualPath="~/Default.aspx" %-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
            CellPadding="3" DataKeyNames="ApplicationId,LoweredUserName" 
            DataSourceID="UserData" AllowSorting="True" CellSpacing="1" GridLines="None">
            <Columns>
                <asp:BoundField DataField="ApplicationId" HeaderText="ApplicationId" 
                    ReadOnly="True" SortExpression="ApplicationId" Visible="False" />
                <asp:BoundField DataField="UserId" HeaderText="UserId" SortExpression="UserId" 
                    Visible="False" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" 
                    SortExpression="UserName" />
                <asp:BoundField DataField="LoweredUserName" HeaderText="LoweredUserName" 
                    SortExpression="LoweredUserName" ReadOnly="True" />
                <asp:BoundField DataField="MobileAlias" HeaderText="MobileAlias" 
                    SortExpression="MobileAlias" />
                <asp:CheckBoxField DataField="IsAnonymous" HeaderText="IsAnonymous" 
                    SortExpression="IsAnonymous" />
                <asp:BoundField DataField="LastActivityDate" HeaderText="LastActivityDate" 
                    SortExpression="LastActivityDate" />
            </Columns>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle ForeColor="Black" BackColor="#DEDFDE" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <asp:SqlDataSource ID="UserData" runat="server" 
            ConnectionString="Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ASPNETDB.MDF;Integrated Security=True;User Instance=True" 
            ProviderName="System.Data.SqlClient" 
            SelectCommand="SELECT [ApplicationId], [UserId], [UserName], [LoweredUserName], [MobileAlias], [IsAnonymous], [LastActivityDate] FROM [vw_aspnet_Users]">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="EventsDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:EventsConnectionString %>" 
            DeleteCommand="DELETE FROM [Events] WHERE [Id] = @Id" 
            InsertCommand="INSERT INTO [Events] ([Title], [Data], [Location]) VALUES (@Title, @Data, @Location)" 
            SelectCommand="SELECT [Id], [Title], [Data], [Location] FROM [Events]" 
            UpdateCommand="UPDATE [Events] SET [Title] = @Title, [Data] = @Data, [Location] = @Location WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Data" Type="DateTime" />
                <asp:Parameter Name="Location" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Data" Type="DateTime" />
                <asp:Parameter Name="Location" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
