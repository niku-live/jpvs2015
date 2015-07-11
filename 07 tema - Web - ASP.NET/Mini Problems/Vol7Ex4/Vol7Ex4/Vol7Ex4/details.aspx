<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="details.aspx.cs" Inherits="Vol7Ex4.details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Data.xml" XPath="Data/User"></asp:XmlDataSource>
        <asp:FormView ID="FormView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataSourceID="XmlDataSource1" GridLines="Horizontal">
            <EditItemTemplate>
                Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                LastName:
                <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                <br />
                Age:
                <asp:TextBox ID="AgeTextBox" runat="server" Text='<%# Bind("Age") %>' />
                <br />
                UserType:
                <asp:TextBox ID="UserTypeTextBox" runat="server" Text='<%# Bind("UserType") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                Name:
                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                LastName:
                <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
                <br />
                Age:
                <asp:TextBox ID="AgeTextBox" runat="server" Text='<%# Bind("Age") %>' />
                <br />
                UserType:
                <asp:TextBox ID="UserTypeTextBox" runat="server" Text='<%# Bind("UserType") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Name:
                <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
                <br />
                LastName:
                <asp:Label ID="LastNameLabel" runat="server" Text='<%# Bind("LastName") %>' />
                <br />
                Age:
                <asp:Label ID="AgeLabel" runat="server" Text='<%# Bind("Age") %>' />
                <br />
                UserType:
                <asp:Label ID="UserTypeLabel" runat="server" Text='<%# Bind("UserType") %>' />
                <br />

            </ItemTemplate>
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
        </asp:FormView>
    
    </div>
    </form>
</body>
</html>
