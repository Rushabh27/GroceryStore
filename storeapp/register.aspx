<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="storeapp.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/style.css" media="screen" type="text/css" />
</head>
<body>
    <div class="login-card">
        <h1>Register</h1><br/>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox CssClass="textboxo" ID="TextBox1" runat="server" placeholder="Email"></asp:TextBox>
            <asp:TextBox CssClass="textboxo" ID="TextBox2" runat="server" placeholder="Email"></asp:TextBox>
            <asp:TextBox CssClass="textboxo" ID="TextBox3" runat="server" placeholder="Password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        </div>
    </form>
        <div class="login-help">
           <a href="login.aspx">Already REgistered!</a>
        </div>
    </div>
</body>
</html>
