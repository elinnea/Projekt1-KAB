using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekt1_KAB
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool isUserLoggedOn = Session["id"] != null;

            if (isUserLoggedOn)
            {
                HyperLinkLogin.Visible = false;
                HyperLinkReg.Visible = false;
                HyperLinkMyPages.Visible = true;
                HyperLinkLogout.Visible = true;
            }
            
        }

    }

}