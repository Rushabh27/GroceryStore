<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="placeOrder.aspx.cs" Inherits="storeapp.placeOrder" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="text-align:center">
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
    </div>
</asp:Content>