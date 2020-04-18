<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="storeapp.register" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="login-card">
        <h1>Register</h1><br/>
        <div>
            <asp:TextBox CssClass="textboxo" ID="TextBox1" runat="server" placeholder="Username"></asp:TextBox>
            <asp:TextBox CssClass="textboxo" ID="TextBox2" runat="server" placeholder="Email"></asp:TextBox>
            <asp:TextBox CssClass="textboxo" ID="TextBox3" runat="server" placeholder="Password"></asp:TextBox>
            <asp:Button CssClass="buttono" ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        </div>
        <div class="login-help">
           <a href="login.aspx">Already Registered!</a>
        </div>
    </div>
</asp:Content>