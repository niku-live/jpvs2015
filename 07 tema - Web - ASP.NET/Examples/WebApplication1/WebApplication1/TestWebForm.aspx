<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWebForm.aspx.cs" Inherits="WebApplication1.TestWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="test.css">
</head>
<body>
    <form id="form1" runat="server" >
    <div>
    
        <asp:Button ID="Button1" CssClass="raudonas_mygtukas" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server"  CssClass="flow"/>       
        <asp:RadioButton ID="RadioButton2" runat="server" CssClass="flow" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
