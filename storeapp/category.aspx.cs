using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace storeapp
{
    public partial class category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds = ser.getcat();
            dt = ds.Tables["category"];
            Response.Write("\n" + "NO." + "NAME" + "\n");

            if (Session["em"] == null)
                Response.Redirect("login.aspx");
        
                foreach (DataRow dr in dt.Rows)
                {
                    //        Response.Write("<img src='" + "~/images/3.jpg" + "'/>");

                    Response.Write("\n" + "<hr/>" + dr["cid"] + "  " + "<a href='" + "product.aspx?cid=" + dr["cid"] + "'>" + "  " + dr["cname"].ToString() + "</a>" + "\t");

                }
            
            

        }

    }
    
}