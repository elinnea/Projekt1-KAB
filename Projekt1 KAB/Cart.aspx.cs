using ClassLibraryKAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekt1_KAB
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] != null)
            {
                Literal1.Text = ((List<Article>)Session["Cart"]).Count.ToString();

                List<Article> cart = (List<Article>)Session["Cart"];

                foreach (var item in cart)
                {
                    Literal1.Text += $"{item.ArticleName} <br>";
                }
            }

            
        }
    }
}