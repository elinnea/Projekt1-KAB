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
    public partial class Redirectpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Session["id"].ToString();
            //int customerID = Convert.ToInt32(Session["id"].ToString());

            //List<OrderHead> orderHeads = ClassLibraryKAB.SQL.ReadOrderHead(customerID);

            //foreach (var orderHead in orderHeads)
            //{
            //    // Change to listbox? literal only takes one orderhead
            //    Literal1.Text = ($"{orderHead.OrderHeadID}, {orderHead.CustomerID}, {orderHead.Discount}, {orderHead.OrderDate}, {orderHead.OrderStatus}");
            //}


            List<Article> articles = SQL.ReadArticles();

            string html = "";

            foreach (Article item in articles)
            {

                html += $"<div class=\"col-sm-4\"><div class=\"panel panel-primary\">";
                html += $"<div class=\"panel-heading\">{item.ArticleName}</div>";
                html += $"<div class=\"panel-body\">{item.ArticleDescription}"; //endast lagt till item.desc... koden
                html += $"<img style='height:100px;' src=\"{item.ArticleImage}\" class=\"img-responsive\" style=\"width:50%\" alt=\"Image\"></div>"; //height från 150 till 100, width från 100 till 50
                html += $"<div class=\"panel - footer\">{item.ArticlePrice.ToString("C2", CultureInfo.CurrentCulture)}</div>";
                html += $"<button onclick=\"BuyItem({item.ArticleID})\" type=\"button\">KÖP</button>";
                html += $"</div></div>";
            }
            dynamicArticles.Text = html;

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