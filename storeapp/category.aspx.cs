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
            /*dt = ds.Tables["category"];
            foreach (DataRow dr in dt.Rows)
            {
               Response.Write("\n"+"<hr/>"+dr["cname"].ToString()+"\n");
                Button b = new Button();
                b.Text = "view";
            }*/
            GridView1.DataSourceID = null;
            GridView1.DataSource = ds;
            GridView1.DataBind();
            

        }

        protected void GridView1_SelectedIndexChanged(object sender, GridViewEditEventArgs e)
        {
            Response.Write(GridView1.SelectedRow.Cells[0].Text);
            int ind=GridView1.SelectedIndex;
            Session["cid"] = GridView1.SelectedDataKey[0].ToString();
            //Response.Redirect("/product.aspx");
        }
    }
}