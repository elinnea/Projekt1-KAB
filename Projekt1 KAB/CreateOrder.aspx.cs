using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using ClassLibraryKAB;

namespace Projekt1_KAB
{
    public partial class OrderHead : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] != null)
            {
                Literal1.Text = ((List<Article>)Session["Cart"]).Count.ToString();

                Customer user = ((Customer)Session["user"]);
                LiteralCustomerID.Text = user.FirstName.ToString();
            }
        }
    }
}