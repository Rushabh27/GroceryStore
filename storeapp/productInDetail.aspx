<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="productInDetail.aspx.cs" Inherits="storeapp.productInDetail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
           <div class="row">
              <div class="col-md-3">
                   <asp:Image ID="Image1" CssClass="img-responsive" runat="server" />
               </div>
                <div class="col-md-5">
                   Product ID:
                   <asp:Label ID="lblProductID" runat="server" Text="Label"></asp:Label>
                  <br />
                   <br />
                   Product Name:
                   <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label>
                   <br />
                   <br />
                   Product Price: &#8377;
                   <asp:Label ID="lblProductPrice" runat="server" Text="Label"></asp:Label>
                   <br />
                  <br />
                   WEIGHT(In Kgs.):
                   <asp:Label ID="lblProductWeight" runat="server" Text="Label"></asp:Label>
                   <br />
                   <br />
                   Quantity:
                   <asp:TextBox ID="txtQuantity" CssClass="form-control" AutoPostBack="true" Text="1" runat="server" OnTextChanged="txtQuantity_TextChanged"></asp:TextBox>
                   <br />
                   <br />
                   Amount: &#8377;
                   <asp:Label ID="lblAmount" runat="server" Text="Label"></asp:Label>
                   <br />
                   <br />
                  <asp:Button ID="btnAddToCart" CssClass="btn btn-success" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click" />
                   <br />
                   <br />
               </div>
           </div>
    </div>
</asp:Content>
   