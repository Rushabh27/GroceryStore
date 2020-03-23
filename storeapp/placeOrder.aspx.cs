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
            Response.Write("<center><h1>ORDER DETAILS</h1></center>" + "\n");
            Response.Write("\n" + "NO." + " " + "NAME" + "  " + "IMAGE" + " " + "WEIGHT(In Kgs.)" + " " + "PRICE" + " " + "\n");

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            int tot = 0;
            ds = ser.getOrder();
            dt = ds.Tables["order"];
            foreach (DataRow dr in dt.Rows)
            {
                Response.Write("\n" + "<hr/>" + dr["oid"] + "  " + dr["oname"].ToString()  + "  " + "<img src='" + Page.ResolveUrl("" + dr["oimage"]) + "'/>" + "  " + dr["weight"] + "  " + dr["price"] + "  " + "\n");
         //       Response.Write("<input type=\"button\" value=\"Remove\" onclick=\"javascript:window.location.href='order.aspx?oid=" + dr["oid"] + "'\" />");
                tot = tot + Convert.ToInt32(dr["price"]);
            }
            Response.Write("\n" + "<center><h2>TOTAL PRICE IS:-" + tot + "</h2></center>");

            Response.Write("\n" + "<center><h2>SHIPPING DETAILS</h2></center>");

        }
    }
}