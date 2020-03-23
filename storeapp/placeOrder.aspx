<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="placeOrder.aspx.cs" Inherits="storeapp.placeOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 89px;
        }
        .auto-style3 {
            margin-left: 70px;
        }
        .auto-style4 {
            margin-left: 44px;
        }
        .auto-style5 {
            margin-left: 87px;
        }
        .auto-style6 {
            margin-left: 75px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <center>
        <p>
            Name :-
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style5" Width="162px"></asp:TextBox>
        </p>
        <p>
            Email :-<asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Width="168px"></asp:TextBox>
        </p>
        <p>
            Address :-<asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style3" Width="168px"></asp:TextBox>
        </p>
        <p>
            Mobile No. :-<asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style4" Width="168px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style6" Text="PLACE ORDER" Width="135px" />
        </p>
    </center>
    </form>
    
</body>

</html>
