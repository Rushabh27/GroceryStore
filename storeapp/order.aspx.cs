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
            Response.Write("<center><h1>YOUR ORDER</h1></center>"+"\n");
         
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds = ser.getPro();
            dt = ds.Tables["product"];
            Response.Write("\n" + "NO."+" " + "NAME"+"  " + "IMAGE"+" " + "WEIGHT(In Kgs.)"+" " + "PRICE"+" " + "\n");
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
            foreach (DataRow dr in dt.Rows)
            {
                Response.Write("\n" + "<hr/>" + dr["oid"] + "  " + "<a href='" + "order.aspx?pid=" + dr["pid"] + "'>" + "  " + dr["oname"].ToString() + "</a>" + "  " + "<img src='" + Page.ResolveUrl("" + dr["oimage"]) + "'/>" + "  " + dr["weight"] + "  " + dr["price"] + "  " + "\n");
                Response.Write("<input type=\"button\" value=\"Remove\" onclick=\"javascript:window.location.href='order.aspx?oid=" + dr["oid"] + "'\" />");
                tot = tot + Convert.ToInt32(dr["price"]);
            }
            Response.Write("\n"+"<center><h2>TOTAL PRICE IS:-" + tot+"</h2></center>");
            Response.Write("\n"+"<input type=\"button\" value=\"BUY\" onclick=\"javascript:window.location.href='placeOrder.aspx" + "'\" />");

        }
    }
}