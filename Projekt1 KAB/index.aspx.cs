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

            List<Article> articles = SQL.ReadArticles();

            string html = "";

            foreach (Article item in articles)
            {
                //Button button = new Button();
                //button.Command += ButtonAddToCart_Click;
                //button.CommandArgument = item.ArticleID.ToString();
                //button.Text = item.ArticleName;
                //articlesForm.Controls.Add(button);

                html += $"<div class=\"col-sm-4\"><div class=\"panel panel-primary\">";
                html += $"<div class=\"panel-heading\">{item.ArticleName}</div>";
                html += $"<div class=\"panel-body\">";
                html += $"<img style='height:150px;' src=\"{item.ArticleImage}\" class=\"img-responsive\" style=\"width:100%\" alt=\"Image\"></div>";
                html += $"<div class=\"panel - footer\">{item.ArticlePrice}</div>";
                html += $"<button onclick=\"BuyItem({item.ArticleID})\" type=\"button\">KÖP</button>";
                html += $"</div></div>";

                //html += $"<input type = \"button\" ID=\"ButtonAddToCart\" Value=\"KÖP\" Onclick=\"ButtonAddToCart_Click\"/>";
            }
            dynamicArticles.Text = html;

        }

        //protected void ButtonAddToCart_Click(object sender, CommandEventArgs e)
        //{
        //    SQL newSQL = new SQL();
        //    int articleID = Convert.ToInt32(e.CommandArgument);
        //    Article article = newSQL.GetArticleByID(articleID);
        //    List<Article> cart;

        //    if (Session["Cart"] == null)
        //    {
        //        cart = new List<Article>();

        //    }
        //    else
        //    {
        //        cart = (List<Article>)Session["Cart"];

        //    }
        //    cart.Add(article);
        //    Session["Cart"] = cart;
        //}
    }

}