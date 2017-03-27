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
            SQL mySQL = new SQL();

            List<Article> articles = SQL.ReadArticles();

            string html = "";

            foreach (Article item in articles)
            {
                html += $"<div class=\"col-sm-4\"><div class=\"panel panel-primary\">";
                html += $"<div class=\"panel-heading\">{item.ArticleName}</div><div class=\"panel-body\">";
                html += $"<img src=\"https://placehold.it/150x80?text=IMAGE\" class=\"img-responsive\" style=\"width:100%\" alt=\"Image\"></div>";
                html += $"<div class=\"panel - footer\">{item.ArticlePrice}</div></div></div>";
            }
            dynamicArticles.Text = html;

            //Article article = mySQL.GetArticleByID(2001);

            //Literal1.Text = article.ArticleName;
            //Literal2.Text = article.ArticlePrice.ToString();

            //if (article.IsInStock)
            //{
            //    CheckBoxInStock.Checked = true;
            //}


        }

    }

}