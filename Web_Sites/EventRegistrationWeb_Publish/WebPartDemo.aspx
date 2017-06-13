<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebPartDemo.aspx.cs" Inherits="WebPartDemo" %>

<%@ Register src="ListEvents.ascx" tagname="ListEvents" tagprefix="uc1" %>
<%@ Register src="Weather.ascx" tagname="Weather" tagprefix="uc2" %>

<%@ Register src="Country.ascx" tagname="Country" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 506px;
        }
        .style3
        {
            width: 506px;
            height: 20px;
        }
        .style4
        {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:WebPartManager ID="WebPartManager1" runat="server">
            <%--<StaticConnections>
                <asp:WebPartConnection ID="CountryConnection" 
                    ConsumerConnectionPointID="CountryConsumer" ConsumerID="Country1" 
                    ProviderConnectionPointID="CountryProvider" ProviderID="ListEvents1">
                </asp:WebPartConnection>
            </StaticConnections>--%>
        </asp:WebPartManager>
    
        <asp:DropDownList ID="DropDownListDisplayModes" runat="server" 
            AutoPostBack="True" 
            onselectedindexchanged="DropDownListDisplayModes_SelectedIndexChanged">
        </asp:DropDownList>
    
    </div>
    <table class="style1">
        <tr>
            <td align="center" class="style2">
                <asp:EditorZone ID="EditorZone1" runat="server" BackColor="#F7F6F3" 
                    BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <asp:AppearanceEditorPart ID="AppearanceEditorPart1" runat="server" />
                        <asp:LayoutEditorPart ID="LayoutEditorPart1" runat="server" />
                    </ZoneTemplate>
                    <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    </EditUIStyle>
                    <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333">
                    </HeaderVerbStyle>
                    <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333">
                    </InstructionTextStyle>
                    <LabelStyle Font-Size="0.8em" ForeColor="#333333"></LabelStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333"></EmptyZoneTextStyle>
                    <ErrorStyle Font-Size="0.8em"></ErrorStyle>
                    <FooterStyle HorizontalAlign="Right" BackColor="#E2DED6"></FooterStyle>
                    <HeaderStyle BackColor="#E2DED6" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333">
                    </HeaderStyle>
                    <PartChromeStyle BorderColor="#E2DED6" BorderWidth="1px" BorderStyle="Solid">
                    </PartChromeStyle>
                    <PartStyle BorderColor="#F7F6F3" BorderWidth="5px"></PartStyle>
                    <PartTitleStyle Font-Bold="True" Font-Size="0.8em" ForeColor="#333333">
                    </PartTitleStyle>
                    <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    </VerbStyle>
                </asp:EditorZone>
            </td>
            <td align="center">
                <asp:CatalogZone ID="CatalogZone1" runat="server" BackColor="#F7F6F3" 
                    BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <asp:PageCatalogPart ID="PageCatalogPart1" runat="server" />
                        <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server">
                            <WebPartsTemplate>
                                <asp:Button ID="Button1" runat="server" Text="Button" />
                            </WebPartsTemplate>
                        </asp:DeclarativeCatalogPart>
                    </ZoneTemplate>
                    <PartLinkStyle Font-Size="0.8em"></PartLinkStyle>
                    <SelectedPartLinkStyle Font-Size="0.8em"></SelectedPartLinkStyle>
                    <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    </EditUIStyle>
                    <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" ForeColor="#333333">
                    </HeaderVerbStyle>
                    <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333">
                    </InstructionTextStyle>
                    <LabelStyle Font-Size="0.8em" ForeColor="#333333"></LabelStyle>
                    <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333"></EmptyZoneTextStyle>
                    <FooterStyle HorizontalAlign="Right" BackColor="#E2DED6"></FooterStyle>
                    <HeaderStyle BackColor="#E2DED6" Font-Bold="True" Font-Size="0.8em" ForeColor="#333333">
                    </HeaderStyle>
                    <PartChromeStyle BorderColor="#E2DED6" BorderWidth="1px" BorderStyle="Solid">
                    </PartChromeStyle>
                    <PartStyle BorderColor="#F7F6F3" BorderWidth="5px"></PartStyle>
                    <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White">
                    </PartTitleStyle>
                    <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333">
                    </VerbStyle>
                </asp:CatalogZone>
            </td>
        </tr>
        <tr>
            <td align="center" class="style2">
                <asp:WebPartZone ID="EventsZone" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" HeaderText="Events" Padding="6">
                    <ZoneTemplate>
                        <uc1:ListEvents ID="ListEvents1" runat="server" />
                    </ZoneTemplate>
                    <MenuLabelHoverStyle ForeColor="#E2DED6" />
                    <MenuLabelStyle ForeColor="White" />
                    <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" 
                        Font-Names="Verdana" Font-Size="0.6em" />
                    <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" ForeColor="#333333" />
                    <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" 
                        ForeColor="White" />
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                    <EmptyZoneTextStyle Font-Size="0.8em" />
                    <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                    <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" 
                        ForeColor="White" />
                    <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                    <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" 
                        ForeColor="White" />
                </asp:WebPartZone>
            </td>
            <td align="center">
                <asp:WebPartZone ID="WeatherZone" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" HeaderText="Weather" Padding="6">
                    <ZoneTemplate>
                        <uc2:Weather ID="Weather1" runat="server" />
                    </ZoneTemplate>
                    <MenuLabelHoverStyle ForeColor="#FFCC66" />
                    <MenuLabelStyle ForeColor="White" />
                    <MenuPopupStyle BackColor="#990000" BorderColor="#CCCCCC" BorderWidth="1px" 
                        Font-Names="Verdana" Font-Size="0.6em" />
                    <MenuVerbHoverStyle BackColor="#FFFBD6" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" ForeColor="#333333" />
                    <MenuVerbStyle BorderColor="#990000" BorderStyle="Solid" BorderWidth="1px" 
                        ForeColor="White" />
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                    <EmptyZoneTextStyle Font-Size="0.8em" />
                    <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                    <PartChromeStyle BackColor="#FFFBD6" BorderColor="#FFCC66" Font-Names="Verdana" 
                        ForeColor="#333333" />
                    <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                    <PartTitleStyle BackColor="#990000" Font-Bold="True" Font-Size="0.8em" 
                        ForeColor="White" />
                </asp:WebPartZone>
            </td>
        </tr>
        <tr>
            <td align="center" class="style3">
                <asp:WebPartZone ID="WebPartZone1" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" Padding="6">
                    <ZoneTemplate>
                        <uc3:Country ID="Country1" runat="server" />
                    </ZoneTemplate>
                    <MenuLabelHoverStyle ForeColor="#E2DED6" />
                    <MenuLabelStyle ForeColor="White" />
                    <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" 
                        Font-Names="Verdana" Font-Size="0.6em" />
                    <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" 
                        BorderStyle="Solid" BorderWidth="1px" ForeColor="#333333" />
                    <MenuVerbStyle BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="1px" 
                        ForeColor="White" />
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White" />
                    <EmptyZoneTextStyle Font-Size="0.8em" />
                    <HeaderStyle Font-Size="0.7em" ForeColor="#CCCCCC" HorizontalAlign="Center" />
                    <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" 
                        ForeColor="White" />
                    <PartStyle Font-Size="0.8em" ForeColor="#333333" />
                    <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" 
                        ForeColor="White" />
                </asp:WebPartZone>
            </td>
            <td align="center" class="style4">
                <asp:ConnectionsZone ID="ConnectionsZone1" runat="server" BackColor="#F7F6F3" 
                    BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Padding="6">
                    <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
                    <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" 
                        ForeColor="#333333" />
                    <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
                    <LabelStyle Font-Size="0.8em" ForeColor="#333333" />
                    <FooterStyle BackColor="#E2DED6" HorizontalAlign="Right" />
                    <HeaderStyle BackColor="#E2DED6" Font-Bold="True" Font-Size="0.8em" 
                        ForeColor="#333333" />
                    <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
                </asp:ConnectionsZone>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
