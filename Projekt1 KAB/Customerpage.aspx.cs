using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekt1_KAB
{
    public partial class Redirectpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["id"].ToString();
        }

        // If you click logout your session will be lost and you will
        // go back to the startpage
        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("index.aspx");
        }
    }
}