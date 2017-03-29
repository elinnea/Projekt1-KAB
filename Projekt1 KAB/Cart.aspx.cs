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
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] != null)
            {
                Literal1.Text = ((List<Article>)Session["Cart"]).Count.ToString();

                List<Article> cart = (List<Article>)Session["Cart"];

                string html = "";
                decimal totalPrice = 0;

                html += "<table class=\"table table-hover\"><thead><tr><th>Produkt</th><th>Pris</th></tr></thead><tbody>";

                foreach (var item in cart)
                {
                    html += $"<tr><td>{item.ArticleName}</td><td>{item.ArticlePrice.ToString("C2", CultureInfo.CurrentCulture)}</td></tr>";
                    totalPrice += item.ArticlePrice;
                }
                html += $"</tbody><thead><tr><th>Total summa</th><th>{totalPrice.ToString("C2", CultureInfo.CurrentCulture)}</th></tr></thead></table>";

                dynamicCart.Text = html;
                Session["totalPrice"] = totalPrice;


            }

        }

        protected void goToCreateOrder_Click(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                Server.Transfer("CreateOrder.aspx");
            }
            else
            {
                Server.Transfer("Login.aspx");
            }
        }

    }
}