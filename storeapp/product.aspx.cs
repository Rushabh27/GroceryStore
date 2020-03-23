using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace storeapp
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds=ser.getPro();
            dt = ds.Tables["product"];
            Response.Write("\n" + "NO." + "NAME" + "IMAGE" + "WEIGHT(In Kgs.)" + "PRICE" + "\n");
            foreach (DataRow dr in dt.Rows)
            {
                if ((dr["catid"]).ToString() == Request.QueryString["cid"])
                {
                    Response.Write("\n" + "<hr/>" + dr["pid"] + "  " + "<a href='" + "order.aspx?pid=" + dr["pid"] + "'>"+"  "+ dr["pname"].ToString() + "</a>"+"  "+"<img src='" + Page.ResolveUrl("" + dr["pimage"]) +"'/>" +"  "+ dr["weight"] + "  " + dr["price"] + "  " + "\n");
                    Response.Write("<input type=\"button\" value=\"ADD\" onclick=\"javascript:window.location.href='order.aspx?pid="+ dr["pid"] +"'\" />");
                }
            }

        }
    }
}