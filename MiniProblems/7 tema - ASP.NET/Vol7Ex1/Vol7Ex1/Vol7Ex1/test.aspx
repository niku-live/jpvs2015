<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Vol7Ex1.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Tekstas:"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Išvalyk" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Prieš tai buvo įvesta:"></asp:Label><asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
