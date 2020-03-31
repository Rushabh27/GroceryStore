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
            Literal1.Text += "<div class='row'>";
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds=ser.getPro();
            dt = ds.Tables["product"];
            foreach (DataRow dr in dt.Rows)
            {
                if ((dr["catid"]).ToString() == Request.QueryString["cid"])
                {
                    Literal1.Text += "<div class='col-sm-4'>";
                    Literal1.Text += "<div class='panel panel-primary'>";
                    Literal1.Text += "<div class='panel-heading'>" + dr["pname"].ToString() + "</div>";
                    Literal1.Text += "<div class='panel-body'>";
                    Literal1.Text += "<img src='" + Page.ResolveUrl("" + dr["pimage"]) + "' class='img-responsive' style='width:100%' alt='Image'>";
                    Literal1.Text += "</div>";
                    Literal1.Text += "<div class='panel-footer'>&#8377;" + dr["price"] + "&nbsp;";
                    Literal1.Text += "<a href='productInDetail.aspx?pid=" + dr["pid"] + "' class='pull-right btn btn-primary' style='margin-top: -7px;'>Buy Now</a></div>";
                    Literal1.Text += "</div>";
                    Literal1.Text += "</div>";

                    
                }
            }
            Literal1.Text += "</div>";
        }
    }
}