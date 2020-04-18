using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace storeapp
{
    public partial class productInDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ServiceReference1.ServiceClient ser = new ServiceReference1.ServiceClient();
            ds = ser.getPro();
            dt = ds.Tables["product"];
            foreach (DataRow dr in dt.Rows)
            {
                if ((dr["pid"]).ToString() == Request.QueryString["pid"])
                {
                    lblProductID.Text = Request.QueryString["pid"];
                    lblProductName.Text = dr["pname"].ToString();
                    lblProductPrice.Text = dr["price"].ToString();
                    lblProductWeight.Text = dr["weight"].ToString();
                    Image1.ImageUrl = Page.ResolveUrl("" + dr["pimage"]);
                    lblAmount.Text = CalculateAmount(txtQuantity.Text, dr["price"].ToString());
                }
            }
        }
        private string CalculateAmount(string Quantity, string Price)
        {
            int qty = int.Parse(Quantity);

            Decimal price = Decimal.Parse(Price);

            Decimal amount = qty * price;

            return amount.ToString();
        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            lblAmount.Text = CalculateAmount(txtQuantity.Text, lblProductPrice.Text);
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/order.aspx?pid=" + Request.QueryString["pid"] + "&qut="+ txtQuantity.Text);
        }
    }
}