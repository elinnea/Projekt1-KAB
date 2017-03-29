using ClassLibraryKAB;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekt1_KAB
{
    public partial class Logout : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();

            Response.Redirect("index.aspx");
        }
    }
}