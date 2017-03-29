using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekt1_KAB
{
    public partial class PayOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal totalPrice = (Convert.ToDecimal(Session["totalPrice"]));

            //LiteralAmount.Text = totalPrice.ToString("C2", CultureInfo.CurrentCulture);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderConfirmation.aspx");
        }
    }
}