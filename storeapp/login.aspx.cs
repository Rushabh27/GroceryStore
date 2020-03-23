using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace storeapp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String em = TextBox1.Text;
            String pa = TextBox2.Text;
            Session["em"] = TextBox1.Text.ToString();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds = ser.getUsr();
            dt = ds.Tables["login"];
            foreach (DataRow dr in dt.Rows)
            {
                if(dr["email"].Equals(em) && dr["password"].Equals(pa))
                {
                    Response.Redirect("category.aspx");
                }
                else
                {
                    Response.Write("Login Failed Try Again");
                }
             
            }

        }
    }
}