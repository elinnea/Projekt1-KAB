using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibraryKAB;

namespace Projekt1_KAB
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Article> articles = new List<Article>();

            foreach (var item in articles)
            {
               
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Button that redirects you to the login page (temporary)
            Response.Redirect("Login.aspx");
        }
    }
}