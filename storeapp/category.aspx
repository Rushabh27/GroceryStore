﻿    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="storeapp.category" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:HyperLinkField NavigateUrl="~/category.aspx" Text="View" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
