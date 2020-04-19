using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace storeapp
{
    public partial class placeOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["em"] == null)
                Response.Redirect("login.aspx");
            int tot = Convert.ToInt32(Request.QueryString["tot"]);
            Response.Write("<center><h1>ORDER DETAILS</h1></center>" + "\n");
            
            Response.Write("\n" + "<center><h2>TOTAL PRICE IS:-" + tot + "</h2></center>");

            Response.Write("\n" + "<center><h2>SHIPPING DETAILS</h2></center>");

        }
    }
}