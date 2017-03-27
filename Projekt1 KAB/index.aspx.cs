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

            foreach (Article item in articles)
            {
                LiteralArticleName.Text +=$"<ul><li>{item.ArticleName}</li>";
                LiteralArticleDescription.Text += $"<li>{item.ArticleDescription}</li>";
                LiteralPrice.Text += $"<li>{item.ArticlePrice}</li></ul>";

                if (item.IsInStock == true)
                {
                    CheckBoxInStock.Checked = true;
                }
            }

        }

    }

}