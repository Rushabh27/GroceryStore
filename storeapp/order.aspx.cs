using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace storeapp
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["em"] == null)
                Response.Redirect("login.aspx");
            Response.Write("<center><h1>YOUR ORDER</h1></center><table style='width: 91 %'><tr><th>" + "\n");
         
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds = ser.getPro();
            dt = ds.Tables["product"];
            Response.Write("NO.</th><th>NAME</th><th>IMAGE</th><th>PRICE</th><th>Total Item</th><th>Total Price of product</th><th></th></tr>");
            foreach (DataRow dr in dt.Rows)
            {
                if ((dr["pid"]).ToString() == Request.QueryString["pid"])
                {
                    ser.Inorder(dr["pname"].ToString(), dr["pimage"].ToString(), Convert.ToInt32(dr["weight"]), Convert.ToInt32(dr["price"]), Convert.ToInt32(dr["pid"]), Convert.ToInt32(dr["catid"]),Convert.ToInt32(Request.QueryString["qut"]));
                }
            }
            if(Request.QueryString["oid"]!=null)
            {
                ser.delOrder(Convert.ToInt32(Request.QueryString["oid"]));
            }
            int tot = 0;
            ds = ser.getOrder();
            dt = ds.Tables["order"];
            int xy=0;
            foreach (DataRow dr in dt.Rows)
            {
                xy++;
                Response.Write("<tr><td width='8%'>" + xy + "</td><td width='12%'>  " + dr["oname"].ToString() + "</td><td width='20%'><img src='" + Page.ResolveUrl("" + dr["oimage"]) + "'/></td><td width='12%'>" + dr["price"]+"/" + dr["weight"] + "kg</td><td width='12%'>" + dr["qwt"] + "</td><td width='15%'>" + Convert.ToInt32(dr["qwt"]) * Convert.ToInt32(dr["price"]) + "</td><td width='12%'>");
                Response.Write("<input type=\"button\" value=\"Remove\" onclick=\"javascript:window.location.href='order.aspx?oid=" + dr["oid"] + "'\" />" + "</td></tr>");
                tot = tot + (Convert.ToInt32(dr["price"])* Convert.ToInt32(dr["qwt"]));
            }
            Response.Write("</table>"+"\n"+"<center><h2>TOTAL PRICE IS:-" + tot+"</h2>");
            Response.Write("\n"+"<input class='buttono' type=\"button\" value=\"BUY\" onclick=\"javascript:window.location.href='placeOrder.aspx?tot="+tot + "'\" /></center>");

        }
    }
}