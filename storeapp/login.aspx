<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="storeapp.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/style.css" media="screen" type="text/css" />
</head>
<body>
    <div class="login-card">
        <h1>Log-in</h1><br/>
        <form id="form1" runat="server">
            <asp:TextBox CssClass="textboxo" ID="TextBox1" runat="server" placeholder="Email"></asp:TextBox>        
            <asp:TextBox CssClass="textboxo" ID="TextBox2" runat="server" placeholder="Password"></asp:TextBox>        
            <asp:Button CssClass="buttono" ID="Button1" runat="server" OnClick="Button1_Click" Text="login"/>
        </form>
        <div class="login-help">
           <a href="register.aspx">New here! Register</a>
        </div>
    </div>
</body>
</html>
