using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace storeapp
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ser.getReg(TextBox1.Text,TextBox2.Text,TextBox3.Text);
        }
    }
}