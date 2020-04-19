<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="storeapp.login" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="login-card">
        <h1>Log-in</h1><br/>
            <asp:TextBox CssClass="textboxo" ID="TextBox1" runat="server" placeholder="Email"></asp:TextBox>        
            <asp:TextBox CssClass="textboxo" ID="TextBox2" runat="server" placeholder="Password"></asp:TextBox>        
            <asp:Button CssClass="buttono" ID="Button1" runat="server" OnClick="Button1_Click" Text="login"/>
        <div class="login-help">
           <a href="register.aspx">New here! Register</a>
        </div>
    </div>

</asp:Content>